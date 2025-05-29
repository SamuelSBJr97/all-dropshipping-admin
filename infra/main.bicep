// main.bicep - Infraestrutura para publicação no Azure
// Gera recursos básicos para microserviços .NET, seguindo boas práticas Azure
// Inclui App Service Plan, App Services, banco de dados SQL, fila RabbitMQ (Azure Service Bus), e outputs obrigatórios

param environmentName string
param location string = resourceGroup().location
param resourceGroupName string

// Token único para nomes de recursos
var resourceToken = uniqueString(subscription().id, resourceGroup().id, environmentName)

// App Service Plan
resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: 'plan-${resourceToken}'
  location: location
  sku: {
    name: 'P1v3'
    tier: 'PremiumV3'
  }
  kind: 'linux'
}

// App Service para API principal
resource apiApp 'Microsoft.Web/sites@2022-03-01' = {
  name: 'dropshipping-api-${resourceToken}'
  location: location
  serverFarmId: appServicePlan.id
  kind: 'app,linux'
  properties: {
    httpsOnly: true
  }
}

// Banco de Dados SQL
resource sqlServer 'Microsoft.Sql/servers@2022-02-01-preview' = {
  name: 'sql-${resourceToken}'
  location: location
  properties: {
    administratorLogin: 'sqladminuser'
    administratorLoginPassword: 'ChangeThisPassword123!'
    version: '12.0'
  }
}

resource sqlDb 'Microsoft.Sql/servers/databases@2022-02-01-preview' = {
  name: '${sqlServer.name}/dropshippingdb'
  location: location
  properties: {
    collation: 'SQL_Latin1_General_CP1_CI_AS'
    maxSizeBytes: 2147483648
    sampleName: 'AdventureWorksLT'
  }
  sku: {
    name: 'Basic'
    tier: 'Basic'
  }
}

// Service Bus para mensageria
resource serviceBus 'Microsoft.ServiceBus/namespaces@2022-10-01-preview' = {
  name: 'sb-${resourceToken}'
  location: location
  sku: {
    name: 'Basic'
    tier: 'Basic'
  }
}

output RESOURCE_GROUP_ID string = resourceGroup().id
