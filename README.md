# Dead simple ML.NET for Scientists, Researchers and Engineers
This repo hosts the working basics of [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet) / [NimbusML](https://docs.microsoft.com/en-us/NimbusML/overview) for educational purposes

The original author of the C# taxi predict notebook is Zeeshan Siddiqui ([codemzs](https://github.com/codemzs))
This is an adapted for teaching and learning the complete ML.NET/NimbusML stack and options.

### Instructions:
1. Download and Install.NET Core 3.1 SDK and 2.1 Core from [here](https://dotnet.microsoft.com/download). You can verify if it's already installed in C:\Program Files\dotnet
2. Clone this lab
3. Install Anaconda, or procure yourself an environment with jupyter notebook.
4. Instal Graphviz from [here](https://graphviz.gitlab.io/download/) (optional) if you don't install this you won't be able to see pipeline visualizations, but the project still works.
5. Open Anaconda Prompt and then
   - 1. Install the dotnet try global tool: `dotnet tool install -g dotnet-try` 
   - 2. Install the .NET kernel: `dotnet try jupyter install` 
   - 3. Verify the .NET kernel is installed: `jupyter kernelspec list`
   - 4. If you installed Graphviz, run the script that puts it on the path: `set_path_graphviz.bat`
   - 5. Go to root of enlistment and run jupyter notebook: `jupyter notebook`