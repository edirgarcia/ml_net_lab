# Really simple ML.NET for Scientists, Researchers and Engineers

In this short workshop you’ll learn the basics of [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet), what it is, how does it work, how can you use it to jumpstart your machine learning projects. 
We will go over examples of models trained directly on C# and models created on Python through [NimbusML](https://docs.microsoft.com/en-us/NimbusML/overview) . Also, you’ll also learn how to operationalize your model in a simple C# app that emulates your service/project. 
Once you have seen how to do it, you will try to train a model yourself. Lastly, we will see a demonstration of the power of the ML.NET AutoML.


### Setup Instructions:
1. Clone this lab using `git clone https://github.com/edirgarcia/ml_net_lab.git` or download and extract the [zip](https://github.com/edirgarcia/ml_net_lab/archive/master.zip)
2. Download and Install .NET Core SDK from [here](https://dotnet.microsoft.com/download). You can verify your installation by typing `dotnet --info` in a console. 
3. Install [Anaconda](https://www.anaconda.com/products/individual), or procure yourself a Python environment with jupyter notebook.
4. Install Graphviz from [here](https://graphviz.gitlab.io/_pages/Download/Download_windows.html) (optional) if you don't install this you won't be able to see pipeline visualizations, but the project still works.
5. Once Anaconda is installed, open Anaconda Prompt and then
   1. Navigate to this enlistment `cd <your_path_here>\ml_net_lab`
   2. Create the ml_net environment `conda env create -f ml_net.yml` (this might take a while)
   3. On a separate cmd Install the [dotnet-interactive](https://github.com/dotnet/interactive) global tool: `dotnet tool install --global Microsoft.dotnet-interactive --version 1.0.115407` 
   4. Activate the conda environment: `conda activate ml_net`
   5. Install the .NET kernel: `dotnet interactive jupyter install` (You might need to close and reopen you Anaconda Prompt for the dotnet interactive tool to load)
   6. Verify the .NET kernel is installed: `jupyter kernelspec list`


### Running Instructions:
1. Open Anaconda Prompt
2. Navigate to this enlistment `cd <your_path_here>\ml_net_lab`
3. Activate the conda environment: `conda activate ml_net`
4. If you installed Graphviz, run the script that puts it on the path: `set_path_graphviz.bat`
5. Run jupyter notebook: `jupyter notebook`

Credit disclaimers:
The original author of the C# taxi predict notebook is Zeeshan Siddiqui ([codemzs](https://github.com/codemzs)), I wrote the NimbusML version attempting to emulate the same pipeline.
The California housing notebooks are loosely based off Shravan Seshadri's workshop on Basic Feature's engineering at the University of Washington Dubstech, which he based of someone else's work whom I can't remember.
So this is an adaptation for teaching and learning some of the ML.NET/NimbusML stack and options.

