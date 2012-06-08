<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PharmaOnDutyDoc.aspx.cs"
    Inherits="PharmacyDuty.Landing.PharmaOnDutyDoc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Landing/Scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
    <link href="Landing/Styles/bootstrap.css" rel="stylesheet" type="text/css" />
    <title>Web Service: Φαρμακεία Αττικής </title>
</head>
<body style="background-image: url('Landing/img/polyester_lite.png'); background-repeat: repeat;">
    <form id="form1" runat="server">
    <div class="hero-unit">
        <h1>
            Public Web Service: Φαρμακεία Αττικής</h1>
        <p>
            Ένα web service που επιστρέφει τα διανυκτερεύοντα φαρμακέια στο νομό Αττικής βάση
            παραμέτρων. Για χρήση σε web apps, mobile applications και ό,τι άλλο σκεφτείτε!</p>
    </div>
    <div class="container">
        <div class="alert alert-info">
            GetAvailableAthensAreas
        </div>

         <div class="alert alert-info">
            GetAvailableDates
        </div>

        <div class="alert alert-info">
            GetPharmaciesOnDuty
        </div>
                
    </div>
    </form>
</body>
</html>
