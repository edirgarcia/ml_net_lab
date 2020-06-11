# Dead simple ML.NET for Scientists, Researchers and Engineers

In this short workshop you’ll learn the basics of [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet), what is it, how does it work, how can you use it to jumpstart your machine learning projects. 
We will go over examples of models trained directly on C#, and models created on Python through [NimbusML](https://docs.microsoft.com/en-us/NimbusML/overview) . Also, you’ll also learn how to operationalize your model in a simple C# app that emulates your service/project. 
Once you have seen how to do it, you will try to train a model yourself. Lastly, we will see a demonstration of the power of the ML.NET AutoML.


### Instructions:
1. Clone this lab
2. Download and Install.NET Core 3.1 SDK and 2.1 Core from [here](https://dotnet.microsoft.com/download). You can verify if it's already installed in C:\Program Files\dotnet
3. Install [Anaconda](https://www.anaconda.com/products/individual), or procure yourself a Python environment with jupyter notebook.
4. Install Graphviz from [here](https://graphviz.gitlab.io/download/) (optional) if you don't install this you won't be able to see pipeline visualizations, but the project still works.
5. Open Anaconda Prompt and then
   1. Install the dotnet try global tool: `dotnet tool install -g dotnet-try` 
   2. Install the .NET kernel: `dotnet try jupyter install` 
   3. Verify the .NET kernel is installed: `jupyter kernelspec list`
   4. If you installed Graphviz, run the script that puts it on the path: `set_path_graphviz.bat`
   5. Go to root of enlistment and run jupyter notebook: `jupyter notebook`

Credit disclaimers:
The original author of the C# taxi predict notebook is Zeeshan Siddiqui ([codemzs](https://github.com/codemzs)), I wrote the NimbusML version attempting to emulate the same pipeline.
The California housing notebooks are loosely based off Shravan Seshadri's workshop on Basic Feature's engineering at the University of Washington Dubstech, which he based of someone else's work whom I can't remember.
So this is an adaptation for teaching and learning the complete ML.NET/NimbusML stack and options.

