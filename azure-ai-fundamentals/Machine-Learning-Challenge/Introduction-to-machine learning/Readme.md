## Introduction
## What are machine learning models?
## Exercise - Create a machine learning model
## What are inputs and outputs?
  - The objective: cost function
  - The data
  - The optimizer
## Exercise - Visualize inputs and outputs
## How to use a model
## Exercise - Use a model
  - Training versus using a model
  - Data for use (need feature only), data for training (need feature and label)
    - features: inputs
    - labels: output and correct answer was
  - I've finished training. What now?
    - We no longer need the original data, the objective function, or the model updater.
## Exercise - Use machine learning models
## Summary
  - The goal of machine learning is to find patterns in data and use these patterns to make estimates.
  - Machine learning differs from normal software development in that we use special code, rather than our own intuition, to improve how well the software works.
  - The learning process conceptually uses four components:
    - Data: about the topic we're interested in.
    - A model, which makes estimates.
    - An objective the model is trying to achieve.
    - An optimizer, which is the extra code that changes the model depending on its performance.
  - Data can be thought of as features, and labels. Features correspond to potential model inputs, while labels correspond to model outputs, or desired model outputs.
  - Pandas and Plotly are powerful tools to explore datasets in Python.
  - Once we have a trained model, we can save to disk for later use.