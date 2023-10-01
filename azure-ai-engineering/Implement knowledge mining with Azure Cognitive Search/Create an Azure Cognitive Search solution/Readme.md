## Introduction
  - Azure Cognitive Search
    - Index documents and data from a range of sources.
    - Use cognitive skills to enrich index data.
    - Store extracted insights in a knowledge store for analysis and integration.
## Azure resources
  - Service tiers and capacity management
    - Replicas and partitions
## Search components
  - Data source
    - Unstructured files in Azure blob storage containers.
    - Tables in Azure SQL Database.
    - Documents in Cosmos DB.
  - Skillset
    - In a basic search solution, you might simply index the data extracted from the data source. 
    - In Azure Cognitive Search, you can apply artificial intelligence (AI) skills as part of the indexing process to enrich the source data with new information, which can be mapped to index fields.
    - Examples of the kind of information that can be extracted by an AI skill include:
      - The language in which a document is written.
      - Key phrases that might help determine the main themes or topics discussed in a document.
      - A sentiment score that quantifies how positive or negative a document is.
      - Specific locations, people, organizations, or landmarks mentioned in the content.
      - AI-generated descriptions of images, or image text extracted by optical character recognition.
      - Custom skills that you develop to meet specific requirements.
  - Indexer
## Understand the indexing process
  - document
      metadata_storage_name
      metadata_author
      content
      normalized_images
        image0
          Text
        image1
          Text
      language
      merged_content
## Search an index
  - Full text search
## Apply filtering and sorting
  - Filtering results
  - Filtering with facets
  - Sorting results
## Enhance the index
  - Search-as-you-type
  - Custom scoring and result boosting
  - Synonyms
## Exercise - Create a search solution
## Summary
  - A data source where the data to be indexed is stored (though you can also push data directly into an index by using the API).
  - A skillset that defines and enrichment pipeline of cognitive skills to enrich the index data.
  - An index that defines fields, which the user can query.
  - An indexer that populates the fields in the index with values extracted from the source data.