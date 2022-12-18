<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653435/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T167315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomFunction.cs](./CS/CustomFilterOperationExample/CustomFunction/CustomFunction.cs) (VB: [CustomFunction.vb](./VB/CustomFilterOperationExample/CustomFunction/CustomFunction.vb))
* [MainWindow.xaml](./CS/CustomFilterOperationExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomFilterOperationExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomFilterOperationExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomFilterOperationExample/MainWindow.xaml.vb))
* [TaskNumsModel.cs](./CS/CustomFilterOperationExample/Model/TaskNumsModel.cs) (VB: [TaskNumsModel.vb](./VB/CustomFilterOperationExample/Model/TaskNumsModel.vb))
<!-- default file list end -->
# How to use a custom function in Conditional Formatting


This example demonstrates how to create and use a custom function operator in Conditional Formatting.<br />With custom functions, you can format rows according to custom rules.<br />For this, we implement the ICustomFunctionOperator interface with a custom function. Then, we register this function operator in the CriteriaOperator's RegisterCustomFunction method.

<br/>


