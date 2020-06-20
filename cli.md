# How to use the ML.NET CLI?

### Setup Instructions:
1. Download and Install.NET Core 3.1 SDK and 2.1 Core from [here](https://dotnet.microsoft.com/download). You can verify if it's already installed in C:\Program Files\dotnet
2. Install the mlnet global tool: `dotnet tool install -g mlnet` 
3. Verify the tool works installed: `mlnet`
4. See malnet help: `mlnet -?`

### Runing Instructions:
1. Train a model using the AutoML: `mlnet regression --dataset datasets/taxi/taxi-fare-train.csv --test-dataset datasets/taxi/taxi-fare-test.csv --label-col FareAmount -o models/cli/ --name taxi`




