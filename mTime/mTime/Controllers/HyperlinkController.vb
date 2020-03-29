﻿Imports System.Net
Imports mTime


Namespace Controllers
    Public Class HyperlinkController
        Inherits Controller

        Private db As New model.MasterDB

        ' GET: Hyperlink
        Function Index() As ActionResult

            ViewBag.TotalCount = db.HYPERLINK.ToList.Count

            '# Return updated dataset
            Return View(db.HYPERLINK.ToList())
        End Function

        Function Details(ByRef id As Integer) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

            If IsNothing(hyperlink) Then
                Return HttpNotFound()
            End If
            Return View(hyperlink)

        End Function


        ' GET : Create-Hyperlink
        Function Create() As ActionResult

            ViewBag.Message = "Created"

            Return View()
        End Function

        'Function Create(<Bind(Include:="HyperlinkID, Title, URL, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn")> ByVal hyperlink As HYPERLINK) As ActionResult

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(ByVal hyperlink As model.HYPERLINK) As ActionResult

            Dim blnIsDuplicated As Boolean

            blnIsDuplicated = db.HYPERLINK.Any(Function(model) model.TITLE = hyperlink.TITLE)

            If blnIsDuplicated = True Then
                ModelState.AddModelError("TITLE", "Title is duplicated")
            Else


                If (ValidateURL(hyperlink.URL)) = False Then
                    ModelState.AddModelError("URL", "URL is invalid")
                End If
            End If

            If ModelState.IsValid Then

                hyperlink.CREATEDON = Now
                hyperlink.CREATEDBY = "Nick"

                db.HYPERLINK.Add(hyperlink)
                db.SaveChanges()

                '* Defined in App_Start->RouteConfig.vb
                Return RedirectToRoute("HyperlinkList")

            End If

            Return View(hyperlink)

        End Function

        Function ValidateURL(ByVal URL As String) As Boolean

            Dim IsValidURL As Boolean = False
            Dim uriResult As Uri = Nothing

            'IsValidURL = Uri.TryCreate(URL, UriKind.Absolute, uriResult) & uriResult.Scheme = Uri.UriSchemeHttp

            If (Uri.IsWellFormedUriString(URL, UriKind.Absolute)) Then
                IsValidURL = True
            End If

            Return IsValidURL

        End Function

        ' GET : Edit-Hyperlink
        Function Edit(ByVal id As Integer) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

            If IsNothing(hyperlink) Then
                Return HttpNotFound()
            End If


            Debug.Print(hyperlink.HYPERLINKID)

            Return View(hyperlink)

        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(ByVal hyperlink As model.HYPERLINK) As ActionResult

            If ModelState.IsValid Then

                Debug.Print(hyperlink.HYPERLINKID)

                db.Entry(hyperlink).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()

                '# Return to Index 
                Return RedirectToAction("Index")

            End If

            Return View(hyperlink)
        End Function

        ' GET : Delete-Hyperlink
        Function Delete(ByVal id As Integer) As ActionResult

            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)

            If IsNothing(hyperlink) Then
                Return HttpNotFound()
            End If
            Return View(hyperlink)

        End Function

        <HttpPost>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult

            Dim hyperlink As model.HYPERLINK = db.HYPERLINK.Find(id)
            db.HYPERLINK.Remove(hyperlink)
            db.SaveChanges()

            '# Return to Index 
            Return RedirectToAction("Index")

        End Function

        Protected Overrides Sub Dispose(disposing As Boolean)

            If (disposing) Then
                db.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        'Function Cancel() As ActionResult
        '    Return RedirectToRoute("HyperlinkList")
        'End Function

    End Class
End Namespace