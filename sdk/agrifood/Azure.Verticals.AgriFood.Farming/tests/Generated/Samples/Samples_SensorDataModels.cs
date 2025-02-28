// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_SensorDataModels
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                measures = new
                {
                    key = new
                    {
                        dataType = "Bool",
                    },
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                measures = new
                {
                    key = new
                    {
                        dataType = "Bool",
                    },
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                measures = new
                {
                    key = new
                    {
                        description = "<description>",
                        dataType = "Bool",
                        type = "<type>",
                        unit = "<unit>",
                        properties = new
                        {
                            key = new object(),
                        },
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<sensorDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                manufacturer = "<manufacturer>",
                productCode = "<productCode>",
                measures = new
                {
                    key = new
                    {
                        description = "<description>",
                        dataType = "Bool",
                        type = "<type>",
                        unit = "<unit>",
                        properties = new
                        {
                            key = new object(),
                        },
                    },
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<sensorDataModelId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModel_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorDataModel("<sensorPartnerId>", "<sensorDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModel_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorDataModelAsync("<sensorPartnerId>", "<sensorDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModel_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetSensorDataModel("<sensorPartnerId>", "<sensorDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModel_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetSensorDataModelAsync("<sensorPartnerId>", "<sensorDataModelId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("manufacturer").ToString());
            Console.WriteLine(result.GetProperty("productCode").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<sensorDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<sensorDataModelId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModels_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorDataModels("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModels_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorDataModelsAsync("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSensorDataModels_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetSensorDataModels("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSensorDataModels_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            SensorDataModels client = new FarmBeatsClient(credential).GetSensorDataModelsClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetSensorDataModelsAsync("<sensorPartnerId>", new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("manufacturer").ToString());
                Console.WriteLine(result.GetProperty("productCode").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("dataType").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("measures").GetProperty("<key>").GetProperty("properties").GetProperty("<key>").ToString());
                Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
