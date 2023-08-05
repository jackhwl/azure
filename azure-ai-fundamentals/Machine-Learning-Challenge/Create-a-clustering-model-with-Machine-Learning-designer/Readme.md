## Identify clustering machine learning scenarios
  - Scenarios for clustering machine learning models
      - Cluster customer attribute data into segments for marketing analysis.
      - Cluster geographic coordinates into regions of high traffic in a city for a ride-share application.
      - Cluster written feedback into topics to prioritize customer service changes.
## What is Azure Machine Learning?
  - Azure Machine Learning workspace
  - Azure Machine Learning studio
  - Azure Machine Learning compute
    - Compute Instances
    - Compute Clusters
    - Inference Clusters
    - Attached Compute
## What is Azure Machine Learning designer?
  - Pipelines
  - Components
  - Datasets
  - Azure Machine Learning Jobs
## Understand steps for clustering
  - Prepare data
  - Train model
  - Evaluate performance
    - Average Distance to Other Center: This indicates how close, on average, each point in the cluster is to the centroids of all other clusters.
    - Average Distance to Cluster Center: This indicates how close, on average, each point in the cluster is to the centroid of the cluster.
    - Number of Points: The number of points assigned to the cluster.
    - Maximal Distance to Cluster Center: The maximum of the distances between each point and the centroid of that point’s cluster. If this number is high, the cluster may be widely dispersed. This statistic in combination with the Average Distance to Cluster Center helps you determine the cluster’s spread.
  - Deploy a predictive service
    - Inference pipeline
    - Deployment
## Exercise - Explore clustering with Azure Machine Learning designer
## Summary: In this module, you learned how to:
  - Identify clustering machine learning scenarios.
  - Use Azure Machine Learning designer to train a clustering model.
  - Use a clustering model for inferencing.
  - Deploy a clustering model as a service.