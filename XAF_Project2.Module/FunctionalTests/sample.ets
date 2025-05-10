;#DropDB XAF_Project2EasyTest

#Application XAF_Project2.Win
#Application XAF_Project2.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef XAF_Project2.Win

*Action About...
 
*Action OK

#EndIf

#IfDef XAF_Project2.Web
*Action Navigation(My Details)
#EndIf
