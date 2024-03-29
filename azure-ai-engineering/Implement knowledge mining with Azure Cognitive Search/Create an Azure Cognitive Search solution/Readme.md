## Introduction
  - Azure Cognitive Search
    - Index documents and data from a range of sources.
    - Use cognitive skills to enrich index data.
    - Store extracted insights in a knowledge store for analysis and integration.
## Manage capacity
  - Service tiers and capacity management
    - Replicas and partitions
## Understand Search components
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
  - Indexer: is the engine that drives the overall indexing process
    - It takes the outputs extracted using the skills in the skillset, along with the data and metadata values extracted from the original data source, and maps them to fields in the index.
  - Index: is the searchable result of the indexing process. It consists of a collection of JSON documents, with fields that contain the values extracted during indexing. Client applications can query the index to retrieve, filter, and sort information.
    - Each index field can be configured with the following attributes:
      - key: Fields that define a unique key for index records.
      - searchable: Fields that can be queried using full-text search.
      - filterable: Fields that can be included in filter expressions to return only documents that match - specified constraints.
      - sortable: Fields that can be used to order the results.
      - facetable: Fields that can be used to determine values for facets (user interface elements used to - filter the results based on a list of known field values).
      - retrievable: Fields that can be included in search results (by default, all fields are retrievable unless this attribute is explicitly removed).
## Understand the indexing process
The indexing process works by creating a document for each indexed entity. During indexing, an enrichment pipeline iteratively builds the documents that combine metadata from the data source with enriched fields extracted by cognitive skills. You can think of each indexed document as a JSON structure, which initially consists of a document with the index fields you have mapped to fields extracted directly from the source data, like this
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

The fields in the final document structure at the end of the pipeline are mapped to index fields by the indexer in one of two ways:

  1. Fields extracted directly from the source data are all mapped to index fields. These mappings can be implicit (fields are automatically mapped to in fields with the same name in the index) or explicit (a mapping is defined to match a source field to an index field, often to rename the field to something more useful or to apply a function to the data value as it is mapped).
  2. Output fields from the skills in the skillset are explicitly mapped from their hierarchical location in the output to the target field in the index.

## Search an index
  - Full text search
    - Simple - An intuitive syntax that makes it easy to perform basic searches that match literal query terms submitted by a user.
    - Full - An extended syntax that supports complex filtering, regular expressions, and other more sophisticated queries.
    - Some common parameters submitted with a query include:
      - search - A search expression that includes the terms to be found.
      - queryType - The Lucene syntax to be evaluated (simple or full).
      - searchFields - The index fields to be searched.
      - select - The fields to be included in the results.
      - searchMode - Criteria for including results based on multiple search terms. 
      
      For example, suppose you search for comfortable hotel. A searchMode value of Any will return documents that contain "comfortable", "hotel", or both; while a searchMode value of All will restrict results to documents that contain both "comfortable" and "hotel".
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

### review