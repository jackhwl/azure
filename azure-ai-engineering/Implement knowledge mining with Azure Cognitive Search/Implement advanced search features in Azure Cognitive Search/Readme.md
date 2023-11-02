## Introduction
## Improve the ranking of a document with term boosting
  - Search an index
  - Write a simple query
  - Enable the Lucene Query Parser
    - Boolean operators: AND, OR, NOT for example luxury AND 'air con'
    - Fielded search: fieldName:search term for example Description:luxury AND Tags:air con
    - Fuzzy search: ~ for example Description:luxury~ returns results with misspelled versions of luxury
    - Term proximity search: "term1 term2"~n for example "indoor swimming pool"~3 returns documents with the words indoor swimming pool within three words of each other
    - Regular expression search: /regular expression/ use a regular expression between / for example /[mh]otel would return documents with hotel and motel
    - Wildcard search: *, ? where * will match many characters and ? matches a single character for example 'air - con'* would find air con and air conditioning
    - Precedence grouping: (term AND (term OR term)) for example (Description:luxury OR Category:luxury) AND Tags:air?con*
    - Term boosting: ^ for example Description:luxury OR Category:luxury^3 would give hotels with the category luxury a higher score than luxury in the description
  - Boost search terms
## Improve the relevance of results by adding scoring profiles
  - How search scores are calculated
    - Improve the score for more relevant documents
  - Add a weighted scoring profile
  - Use functions in a scoring profile
## Improve an index with analyzers and tokenized terms
  - Analyzers in Cognitive Search
    - Language analyzers
    - Specialized analyzers
  - What is a custom analyzer?
    - Character filters
    - Tokenizers
    - Token filters
  - Create a custom analyzer
  - Test a custom analyzer
  - Use a custom analyzer for a field