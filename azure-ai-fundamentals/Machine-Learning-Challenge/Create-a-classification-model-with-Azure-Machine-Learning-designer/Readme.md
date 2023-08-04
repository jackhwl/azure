## Identify classification machine learning scenarios
  - Scenarios for classification machine learning models
      - Using clinical data to predict whether a patient will become sick or not.
      - Using historical data to predict whether text sentiment is positive, negative, or neutral.
      - Using characteristics of small businesses to predict if a new venture will succeed.
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
## Understand steps for classification
  - Prepare data
  - Train model
    - Classification
  - Evaluate performance
    - Confusion matrix
      - Accuracy: The number of correct predictions (true positives + true negatives) divided by the total number of predictions.
      - Precision: The number of the cases classified as positive that are actually positive: the number of true positives divided by (the number of true positives plus false positives).
      - Recall: The fraction of positive cases correctly identified: the number of true positives divided by (the number of true positives plus false negatives).
      - F1 Score: An overall metric that essentially combines precision and recall.
    - Choosing a threshold
    - ROC curve and AUC metric
  - Deploy a predictive service
    - Inference pipeline
    - Deployment
