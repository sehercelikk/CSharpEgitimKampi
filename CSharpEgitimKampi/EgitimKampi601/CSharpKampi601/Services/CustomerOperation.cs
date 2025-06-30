using CSharpKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKampi601.Services
{
    public class CustomerOperation
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection= connection.GetCustomerCollection();
            var document = new BsonDocument
            {
                {"Name",customer.Name },
                {"Surname", customer.Surname },
                {"City", customer.City },
                {"Balance", customer.Balance },
                {"ShoppingCount", customer.ShoppingCount }
            };
            customerCollection.InsertOne(document);
        }

        public List<Customer> GetAllCustomer()
        {
            var connection=new MongoDbConnection();
            var customerCollection= connection.GetCustomerCollection();
            var customers=customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> CustomerList= new List<Customer>();
            foreach (var c in customers)
            {
                CustomerList.Add(new Customer
                {
                    CustomerId = int.Parse(c["_id"].ToString()),
                    Balance = decimal.Parse(c["Balance"].ToString()),
                    City = c["City"].ToString(),
                    Name = c["Name"].ToString(),
                    Surname = c["Surname"].ToString(),
                    ShoppingCount =int.Parse(c["ShoppingCount"].ToString())
                });
            }
            return CustomerList;
        }
       
        
        public void DeleteCustomer(string id)
        {
            var connection= new MongoDbConnection();
            var customerCollection= connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer)
        {
            string id =customer.CustomerId.ToString();
            var connection= new MongoDbConnection();
            var customerCollection= connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("Name", customer.Name)
                .Set("Surname", customer.Surname)
                .Set("Balance", customer.Balance)
                .Set("City", customer.City)
                .Set("ShoppingCount", customer.ShoppingCount);
            customerCollection.UpdateOne(filter,updatedValue);
        }

        public Customer GetCustomerById(string id)
        {
            var connection=new MongoDbConnection();
            var customerCollection=connection.GetCustomerCollection();
            var filter= Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
            var result= customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                Balance =decimal.Parse(result["Balance"].ToString()),
                City = result["City"].ToString(),
                Name = result["Name"].ToString(),
                Surname = result["Surname"].ToString(),
                ShoppingCount = int.Parse(result["ShoppingCount"].ToString())
            };
        }
    }

}
