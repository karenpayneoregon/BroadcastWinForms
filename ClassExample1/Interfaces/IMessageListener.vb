''' <summary>
''' This Interface controls the type used for passing objects,
''' in this case its a class instance.
''' 
''' Other possibilities
''' * DataTable
''' * DataRow
''' * String, Integer, DateTime etc
''' </summary>
''' <remarks>
''' When changing from Person to another type changes must be reflected in Broadcaster
''' * Once changes are made here, build the project, there should be several errors pointing
'''   to Person is the wrong type, change to match the first parameter in OnListen below,
'''   build the project, fix any other issues which will be the exact same as above, fix,
'''   build and go.
''' </remarks>
Public Interface IMessageListener
    Sub OnListen(person As Person, form As Form)
End Interface
