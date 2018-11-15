<!-- default file list -->
*Files to look at*:

* [CustomFunction.cs](./CS/CustomFilterOperationExample/CustomFunction/CustomFunction.cs) (VB: [CustomFunction.vb](./VB/CustomFilterOperationExample/CustomFunction/CustomFunction.vb))
* [MainWindow.xaml](./CS/CustomFilterOperationExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomFilterOperationExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomFilterOperationExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/CustomFilterOperationExample/MainWindow.xaml))
* [TaskNumsModel.cs](./CS/CustomFilterOperationExample/Model/TaskNumsModel.cs) (VB: [TaskNumsModel.vb](./VB/CustomFilterOperationExample/Model/TaskNumsModel.vb))
<!-- default file list end -->
# How to use a custom function in Conditional Formatting


This example demonstrates how to create and use a custom function operator in Conditional Formatting.<br />With custom functions, you can format rows according to custom rules.<br />For this, we implement the ICustomFunctionOperator interface with a custom function. Then, we register this function operator in the CriteriaOperator's RegisterCustomFunction method.

<br/>


