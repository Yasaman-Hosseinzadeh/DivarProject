using DivarProjectWithWinForm.Enums;
using DivarProjectWithWinForm.Extentions;
using DivarProjectWithWinForm.Models.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivarProjectWithWinForm.Business
{
    public static class DatabaseBusiness
    {
        const string connectionString = "Server=.;Database=DivarProjectDB;User Id=yhosseinzade;Password=!@#Yy3345809;Integrated Security=True";

        private static async Task<List<T>> GetData<T>(Func<SqlDataReader, T> mapData, string tableName, Dictionary<string, string>? whereCluaseDictionary = null)
        {
            var data = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT * FROM dbo.{tableName}";
                    if (whereCluaseDictionary != null)
                        query += $" WHERE {string.Join("AND", whereCluaseDictionary.NormilizeWhereClause())}";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        data.Add(mapData(reader));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
                return data;
            }
        }

        public static async Task<List<User>> GetUsers()
        {
            User Map(SqlDataReader reader)
            {
                return new User
                {
                    Id = (int)reader["Id"],
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"].ToString()),
                    ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"].ToString()),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    NationalCode = reader["NationalCode"].ToString(),
                    CellNumber = reader["CellNumber"].ToString()
                };
            }
            return await GetData(Map, "User");
        }

        public static async Task<List<Advertisement>> GetAdvertisement(Status? status = null)
        {
            Advertisement Map(SqlDataReader reader)
            {
                return new Advertisement
                {
                    Id = (int)reader["Id"],
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"].ToString()),
                    ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"].ToString()),
                    CategoryId = (int)reader["CategoryId"],
                    CreatorUserId = (int)reader["CreatorUserId"],
                    IntactStatus = (IntactStatus)reader["IntactStatus"],
                    Status = (Status)reader["Status"],
                    Price = (int)reader["Price"],
                    Title = reader["Title"].ToString(),
                    Address = reader["Address"].ToString(),
                    Description = reader["Description"].ToString(),
                };
            }
            var whereCluaseDictionary = new Dictionary<string, string>();
            whereCluaseDictionary = null;
            if (status != null)
            {
                whereCluaseDictionary = new Dictionary<string, string>()
                 {
                    { "Status", ((int)status).ToString() }
                };
            }
            return await GetData(Map, "Advertisement", whereCluaseDictionary);
        }

        public static async Task<List<Category>> GetCategory(int? categoryId = null)
        {
            Category Map(SqlDataReader reader)
            {
                return new Category
                {
                    Id = (int)reader["Id"],
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"].ToString()),
                    ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"].ToString()),
                    Title = reader["Title"].ToString()
                };
            }
            var whereCluaseDictionary = new Dictionary<string, string>();
            whereCluaseDictionary = null;
            if (categoryId != null)
            {
                whereCluaseDictionary = new Dictionary<string, string>() {
                    { "Id", categoryId.ToString() }
                };
            }
            return await GetData(Map, "Category", whereCluaseDictionary);
        }

        public static async Task<Advertisement> CreateAdvertisement(Advertisement advertisement)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //VALUES('{advertisement.CreatedDate}','{advertisement.ModifiedDate}',{advertisement.CategoryId},{advertisement.CreatorUserId},{(int)advertisement.IntactStatus},{(int)advertisement.Status},{advertisement.Price},N'{advertisement.Title}',N'{advertisement.Address}',N'{advertisement.Description}',{advertisement.IsFixedPrice.ConvertToInt()},{advertisement.LikeToExchange.ConvertToInt()})";

                    string query = @$"INSERT INTO [dbo].[Advertisement]([CreatedDate],[ModifiedDate],[CategoryId],[CreatorUserId],[IntactStatus],[Status],[Price],[Title],[Address],[Description],[IsFixedPrice],[LikeToExchange])                    
                    OUTPUT inserted.Id
                    VALUES(@CreatedDate,@ModifiedDate,@CategoryId,@CreatorUserId,@IntactStatus,@Status,@Price,@Title,@Address,@Description,@IsFixedPrice,@LikeToExchange)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CreatedDate", advertisement.CreatedDate);
                    command.Parameters.AddWithValue("@ModifiedDate", advertisement.ModifiedDate);
                    command.Parameters.AddWithValue("@CategoryId", advertisement.CategoryId);
                    command.Parameters.AddWithValue("@CreatorUserId", advertisement.CreatorUserId);
                    command.Parameters.AddWithValue("@IntactStatus", advertisement.IntactStatus);
                    command.Parameters.AddWithValue("@Status", advertisement.Status);
                    command.Parameters.AddWithValue("@Price", advertisement.Price);
                    command.Parameters.AddWithValue("@Title", advertisement.Title);
                    command.Parameters.AddWithValue("@Address", advertisement.Address);
                    command.Parameters.AddWithValue("@Description", advertisement.Description);
                    command.Parameters.AddWithValue("@IsFixedPrice", advertisement.IsFixedPrice);
                    command.Parameters.AddWithValue("@LikeToExchange", advertisement.LikeToExchange);
                    command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;


                    var id = await command.ExecuteScalarAsync();
                    if (id != null)
                        advertisement.Id = (int)id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
                return advertisement;
            }
        }

        public static async Task ChangeStatusAdvertisement(int advertisementId, Status status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @$"UPDATE [dbo].[Advertisement] SET [ModifiedDate] = GETDATE(), [Status] = {status} WHERE Id = {advertisementId}";
                    SqlCommand command = new SqlCommand(query, connection);

                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private static List<string> NormilizeWhereClause(this Dictionary<string, string> whereCluaseDictionary)
        {
            var result = new List<string>();
            foreach (var item in whereCluaseDictionary)
                result.Add($"{item.Key} = {item.Value}");
            return result;
        }
    }
}