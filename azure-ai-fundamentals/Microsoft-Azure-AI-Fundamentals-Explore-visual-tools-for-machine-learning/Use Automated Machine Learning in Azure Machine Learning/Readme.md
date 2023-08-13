## Introduction
## What is machine learning?
  - Types of machine learning
    - supervised machine learning
      - Regression
      - Classification
    - unsupervised machine learning
      - Clustering
## What is Azure Machine Learning studio?
  - Azure Machine Learning workspace
  - Azure Machine Learning studio
  - Azure Machine Learning compute
    - Compute Instances
    - Compute Clusters
    - Inference Clusters
    - Attached Compute
## What is Azure Automated Machine Learning?
## Understand the AutoML process
  - Prepare data: Identify the features and label in a dataset. Pre-process, or clean and transform, the data as needed
  - Train models: Split the data into two groups, a training and a validation set. Train a machine learning model using the training data set. Test the machine learning model for performance using the validation data set.
    - Classification: Predict a category or class label, such as "spam" or "not spam".
    - Regression: Predict a numerical value, such as the price of a house.
    - Time series forecasting: Predict future values based on previously observed values at a future point in time.
  - Evaluate performance: Compare how close the model's predictions are to the known labels.
    - metric root mean squared error (RMSE)
    - metric normalized root mean squared error (NRMSE)
    - Residual Histogram
  - Deploy a predictive service: After you train a machine learning model, you can deploy the model as an application on a server or device so that others can use it.