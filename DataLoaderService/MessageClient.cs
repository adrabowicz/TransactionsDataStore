using System;
using System.Collections.Generic;
using Elasticsearch.Net;
using CommonData.Metadata;

namespace DataLoaderService
{
    public class MessageClient
    {
        private static readonly string elasticsearchUrl = "http://localhost:9200";
        private static readonly string indexName = "transaction-index";
        private static readonly string transactionType = "transaction";

        private static ElasticLowLevelClient lowlevelClient;

        public static void SetupClient()
        {
            var settings = new ConnectionConfiguration(new Uri(elasticsearchUrl));
            settings.RequestTimeout(TimeSpan.FromMinutes(2));

            lowlevelClient = new ElasticLowLevelClient(settings);
        }

        public static void LoadPersonDataIntoIndex(List<Person> data)
        {
            foreach (var person in data)
            {
                var body = PostData.Serializable(person);
                var response = lowlevelClient.Index<StringResponse>(indexName, "person", person.Id, body);
                var responseString = response.Body;
            }
        }

        public static void LoadTransactionDataIntoIndex(List<AppTile> data)
        {
            foreach (var transaction in data)
            {
                var body = PostData.Serializable(transaction);
                var response = lowlevelClient.Index<StringResponse>(indexName, transactionType, body);
                var responseString = response.Body;
            }
        }
    }
}
