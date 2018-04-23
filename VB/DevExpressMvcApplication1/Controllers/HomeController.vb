﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc

Namespace DevExpressMvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Return View(NorthwindDataProvider.GetProducts())
		End Function

		Public Function InlineEditingPartial() As ActionResult
			Return PartialView("GridView", NorthwindDataProvider.GetEditableProducts())
		End Function
	End Class
End Namespace
