## Introduction
## Understand custom named entity recognition
  - Custom vs built-in NER
  - Azure AI Language Service project life cycle
    - Define entities: Understanding the data and entities you want to identify, and try to make them as clear as possible. For example, defining - exactly which parts of a bank statement you want to extract.
    - Tag data: Label, or tag, your existing data, specifying what text in your dataset corresponds to which entity. This step is important to do - accurately and completely, as any wrong or missed labels will reduce the effectiveness of the trained model. A good variation of possible input - documents is useful. For example, label bank name, customer name, customer address, specific loan or account terms, loan or account amount, and - account number.
    - Train model: Train your model once your entities are labeled. Training teaches your model how to recognize the entities you label.
    - View model: After your model is trained, view the results of the model. This page includes a score of 0 to 1 that is based on the precision and - recall of the data tested. You can see which entities worked well (such as customer name) and which entities need improvement (such as account - number).
    - Improve model: Improve your model by seeing which entities failed to be identified, and which entities were incorrectly extracted. Find out what - data needs to be added to your model's training to improve performance. This page shows you how entities failed, and which entities (such as - account number) need to be differentiated from other similar entities (such as loan amount).
    - Deploy model: Once your model performs as desired, deploy your model to make it available via the API. In our example, you can send to requests - to the model when it's deployed to extract bank statement entities.
    - Extract entities: Use your model for extracting entities. The lab covers how to use the API, and you can view the API reference for more - details.  
  - Considerations for data selection and refining entities
    - Diversity - use as diverse of a dataset as possible without losing the real-life distribution expected in the real data. You'll want to use - sample data from as many sources as possible, each with their own formats and number of entities. It's best to have your dataset represent as - many different sources as possible.
    - Distribution - use the appropriate distribution of document types. A more diverse dataset to train your model will help your model avoid learning - incorrect relationships in the data.
    - Accuracy - use data that is as close to real world data as possible. Fake data works to start the training process, but it likely will differ - from real data in ways that can cause your model to not extract correctly.  
  - How to extract entities
  - Project limits
    - Training - at least 10 files, and not more than 100,000
    - Deployments - 10 deployment names per project
    - APIs
      - Authoring - this API creates a project, trains, and deploys your model. Limited to 10 POST and 100 GET per minute
      - Analyze - this API does the work of actually extracting the entities; it requests a task and retrieves the results. Limited to 20 GET or POST
    - Projects - only 1 storage account per project, 500 projects per resource, and 50 trained models per project
    - Entities - each entity must be fewer than 10 words and 100 characters, up to 200 entity types, and at least 10 tagged instances per entity
## Label your data
  - How to label your data
## Train and evaluate your model
  - Recall & Precision
    - Accuracy: (TP+TN)/(TP+TN+FP+FN) - out all of the predictions, how many were correct?
    - Recall (Sensitivity): TP/(TP+FN) - of all the cases that are positive, how many did the model identify?
    - Precision: TP/(TP+FP) - of all the cases that the model predicted to be positive, how many actually are positive?
  - Recall & Precision
  - Recall: TP/(TP+FN) - of all the cases that are positive, how many did the model identify?
  - Precision: TP/(TP+FP) - of all the cases that the model predicted to be positive, how many actually are positive?

  - Precision	The ratio of successful entity recognitions to all attempted recognitions. A high score means that as long as the entity is recognized, it's labeled correctly.
  - Recall	The ratio of successful entity recognitions to the actual number of entities in the document. A high score means it finds the entity or entities well, regardless of if it assigns them the right label
## Exercise - Extract custom entities
  - Create an Azure AI Language Service resource
    - Get Azure AI Language resource key and endpoint
  - Upload sample ads
  - Create a custom named entity recognition project
  