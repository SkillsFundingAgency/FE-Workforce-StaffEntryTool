# Introduction 
The FEW Staff Entry tool demonstrates Further Education workforce data entry using a C# tool rather than Excel or similar existing tool.

# Getting Started
The tool is based on v13 of the XSD with a modification to add an 'array' of StaffData elements.
This has been used to create a set of Model classes that can be found in ESFA.FEW.Models.
The technique used was: 
https://stackoverflow.com/questions/5217665/how-to-generate-net-4-0-classes-from-xsd
And the 'paste XML as classes'.
Each control value list has a tab seperated txt file that is loaded on start up.
The CVL's are then used to populate each of the combo drop down columns.
They are also used when the data is exported to XML to convert back to 'codes'.

Columns are named as datatype_fieldname - this allows us to use reflection to go backwards and forwards between the grid of data
and the model (ahead of serialisation).

ColumnToModelMapper contains most of the clever code.
The 'Paste' function is a a context menu function added in the form itself - this is where we could transform
user input into the correct values.


# Build and Test
Checkout, make sure you can see ESFA nuget servers, build.

# Contribute
POC code.
Not amazingly stable (but not awful); can cause it to crash by clicking in wrong place etc
If there are missing bits of enums then can crash
No support for 'role' elements/entities.
No import, just export :)
Colour coding of data is based on 'you modified the cell' and nothing cleverer than that at the moment

