## Introduction
  - Learning objectives
## What is Azure Cognitive Search?
  - Azure Cognitive Search features
    - Data from any source
    - Full text search and analysis
    - AI-powered search
    - Multi-lingual
    - Geo-enabled
    - Configurable user experience
## Identify elements of a search solution
## Use a skillset to define an enrichment pipeline
  - Built in skills
    - Natural language processing skills
    - Image processing skills
## Understand indexes
  - Index schema
  - Index attributes
## Use an indexer to build an index
  * Push method 
  * Pull method
  - Use the pull method to load data with an indexer
  - Data import monitoring and verification
  - Making changes to an index
## Persist enriched data in a knowledge store
  - Table projections are used to structure the extracted data in a relational schema for querying and visualization
  - Object projections are JSON documents that represent each data entity
  - File projections are used to store extracted images in JPG format
## Create an index in the Azure portal
  - Supported data sources:
    - Cosmos DB (SQL API)
    - Azure SQL (database, managed instance, and SQL Server on an Azure VM)
    - Azure Storage (Blob Storage, Table Storage, ADLS Gen2)
  - Using the Azure portal's Import data wizard
    - Data Source
    - Index
    - Indexer: An indexer serializes a source document into JSON before passing it to a search engine for indexing. An indexer automates several steps of data ingestion, reducing the amount of code you need to write.
    - Skillset
    - Knowledge store
## Query data in an Azure Cognitive Search index
  - Simple query requests
## Exercise - Explore knowledge mining