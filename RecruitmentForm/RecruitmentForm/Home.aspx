<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RecruitmentForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs4/dt-1.10.18/datatables.min.css" />
    <link href="Content/Site.css" rel="stylesheet" />
</head>

<body>

    <nav class="navbar navbar-expand-lg bg-dark navbar-dark">
        <!-- Brand/logo -->
        <a class="navbar-brand" href="#">
            <img src="Content/ta.jpg" width="50" height="50" />
        </a>
        <p class="h3 text-center text-white" style="text-align: center">Recruitment Form </p>
        
    </nav>
    <br />  
    <form id="form1" runat="server">
        <div class="container">
            <p class="h3 text-center">Employee Recruitment Board</p>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6">
                    <table class="table table-borderless" align="center">
                        <tbody>
                            <tr>
                                <td>
                                    <label><strong>Select Practice</strong> </label></td>
                                <td align="right">
                                    <select id="practice" class="form-control" style="height: 30px; width: 200px">
                                        <option value="Select Practice">Select Practice</option>
                                    </select>

                                </td>
                            </tr>

                        </tbody>
                    </table>
                    <br />

                </div>
                <div class="col-md-3"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <table id="Employees" class="table table-bordered">
                        <thead>
                            <tr>
                                <th>S.No</th>
                                <th>Candidate Name</th>
                                <th>Hiring Position</th>
                                <th>Candidate Email</th>
                                <th>Contact Number</th>
                                <th>Start Flow</th>
                                <th>Status</th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>



        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.js" integrity="sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="Content/custom.js"></script>
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
</body>
</html>
