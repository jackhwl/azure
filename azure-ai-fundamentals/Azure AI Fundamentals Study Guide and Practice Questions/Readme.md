# Describe Artificial Intelligence workloads and considerations (20–25%)
## CHAPTER 1 - IDENTIFY FEATURES OF COMMON AI WORKLOADS
  - Prediction/Forecasting Workloads
  - Anomaly Detection Workloads
  - Computer Vision Workloads
  - Natural Language Processing and Knowledge Mining Workloads
  - Conversational AI Workloads
## CHAPTER 2 - IDENTIFY GUIDING PRINCIPLES FOR AI
  - Fairness
  - Reliability and Safety
  - Privacy and Security
  - Inclusiveness
  - Transparency
  - Accountability

# Describe fundamental principles of machine learning on Azure (25–30%)
## CHAPTER 3 – IDENTIFY COMMON MACHINE LEARNING TYPES
  - Supervised Learning
    - Classification: uses supervised learning to label data
    - Regression: uses supervised learning to predict numerical data
  - Semi-supervised learning
  - Unsupervised Learning
    - Clustering: uses unsupervised learning to find patterns in the data
    - Anomaly detection: uses unsupervised learning to identify unusual patterns that do not conform to expected behavior
    - Dimensionality reduction: uses unsupervised learning to reduce the number of variables in a dataset
  - Reinforcement Learning: tries to achieve a goal through random trial and error by grading the performance of each attempt
## CHAPTER 4 – DESCRIBE CORE MACHINE LEARNING CONCEPTS
  - Features and Labels in a Dataset for ML
    - Features: are characteristics that are measured to determine an appropriate label
    - Labels: are the values that you want to predict from the features
  - Training and Validation Datasets in ML
    - Training dataset: is used to train the model
    - Validation dataset: is used to evaluate the model， ensure that the model is not overfitting the training dataset
    - Test dataset: is used to test the model after it has been trained and tuned, determine how well the model performs against new data
  - ML Algorithms for Model Training
  - Model Evaluation Metrics for Classification and Regression
    - Accuracy: (TP+TN)/(TP+TN+FP+FN) - out all of the predictions, how many were correct?
    - Recall (Sensitivity): TP/(TP+FN) - of all the cases that are positive, how many did the model identify?
    - Precision: TP/(TP+FP) - of all the cases that the model predicted to be positive, how many actually are positive?
    - F1 Score: 2 * (Precision * Recall) / (Precision + Recall) - a single metric that combines both precision and recall
    - ROC Curve
    - MAE finds the average absolute distance and MSE finds the average squared error
## CHAPTER 5 – IDENTIFY CORE TASKS IN CREATING A MACHINE LEARNING SOLUTION
  - Data Ingestion and Preparation
  - Feature Selection and Engineering
    - Feature selection: is the process of choosing the most relevant features in your data
    - Feature engineering: is the process of transforming raw data into features that better represent the underlying problem to the predictive models, resulting in improved model accuracy on unseen data
  - Model Training and Evaluation
  - Model Deployment and Management
## CHAPTER 6 – DESCRIBE THE CAPABILITIES OF NO-CODE MACHINE LEARNING WITH AZURE MACHINE LEARNING
  - Azure Machine Learning Designer
  - Automated Machine Learning

# Describe features of computer vision workloads on Azure (15–20%)
## CHAPTER 7 – IDENTIFY COMMON TYPES OF COMPUTER VISION SOLUTIONS
  - Image classification
  - Object detection
  - Semantic Segmentation
  - Optical Character Recognition
  - Facial Detection
## CHAPTER 8 – IDENTIFY AZURE TOOLS AND SERVICES FOR COMPUTER VISION TASKS
  - Computer Vision
    - Read API
    - OCR API
  - Custom Vision
    - Image classification can apply labels to an image while object detection can identify the coordinates where the labels can be found.
  - Face
    - Know the differences between each of the API’s: 
      - Face (coordinates), 
      - Verify (detect if same person), 
      - Group (finds similarities), 
      - Identify (ID against database)
  - Form Recognizer
    - Custom models - Extract key data from forms.
    - Prebuilt receipt model - Extract data from receipts.
    - Layout API - Extract text and table structures from documents.

# Describe features of Natural Language Processing (NLP) workloads on Azure (25–30%)
## CHAPTER 9 – IDENTIFY FEATURES FOR COMMON NLP WORKLOAD SCENARIOS
  - Key phrase extraction
  - Entity recognition
  - Sentiment analysis
  - Language modeling
  - Speech recognition and synthesis
  - Translation
## CHAPTER 10 – IDENTIFY AZURE TOOLS AND SERVICES FOR NLP WORKLOADS
  - Text Analysis
    - Sentiment Analysis - Microsoft provides analysis models that are pretrained using natural language technologies from Microsoft.
    - Key Phrase Extraction
    - Language Detection – The API can detect which language is input and provide a score indicating confidence level.
    - Named Entity Recognition - Identify and categorize entities in your text (e.g., date/time, people, places, things, etc.)
  - Language Understanding Intelligence Service
  - Speech
  - Text Translator
