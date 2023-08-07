## Normalization and standardization
  - Normalization versus standardization
  - Why do we need to scale?
  - Scaling gives learning a better starting point
  - Standardization lets parameters train at the same speed
  - Scaling helps with multiple features
## Exercise – Feature scaling
## Test and training datasets
  - What is overfitting?
  - How can we avoid overfitting?
  - What is a test dataset?
  - OK, but what’s the point?
  - What does that mean for cost functions?
## Exercise - Test and train datasets
## Nuances of test sets
  - Test sets can be misleading
  - Test sets aren't free
  - Train and test isn't the only approach
    - The hold-out approach
    - Statistical approaches
## Exercise – Test set nuances
## Summary
  - You can use different ratios when splitting your dataset into train and test sets.
  - Different ratios yield different distributions of variables in the resulting train and test sets.
  - When the train:test ratios are close, you're possibly leaving a lot of data out of the training set, and that can have a negative impact on your model's performance.
  - When building models, it's important to test them using different train/test splits. Simply assigning more data to the train set doesn't always guarantee the best results.