<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PharmaOnDutyDoc.aspx.cs"
    Inherits="PharmacyDuty.Landing.PharmaOnDutyDoc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script src="Landing/Scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
    <link href="Landing/Styles/bootstrap.css" rel="stylesheet" type="text/css" />
    <title>Web Service: Φαρμακεία Αττικής </title><a href="https://github.com/georgespingos/AtticaPharmacies">
        <img style="position: absolute; top: 0; right: 0; border: 0;" src="Landing/img/fork_me.png"
            alt="Fork me on GitHub">
    </a></>
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
        <div class="well hero-unit">
            <h2>
                <strong>Web Service URL: <a href="http://pharmaonduty.apphb.com">http://pharmaonduty.apphb.com</a></strong>
            </h2>
        </div>
        <div>
            <p class="lead">
                Available Methods:</p>
        </div>
        <div class="alert alert-info">
            <span class="label label-success">You need this...</span>
            <h3>
                List &ltAthensArea&gt GetAvailableAthensAreas()</h3>
            <div style="margin-top: 10px;">
                <pre>
            <code>AthensArea[] Areas = client.GetAvailableAthensAreas(); </code>
            </pre>
            </div>
            <p>
                Επιστρέφει ένα array από Objects τύπου AthensArea που αντιπροσωπεύουν τις διαθέσιμες
                περιοχές της Αττικής.
            </p>
            <p>
                Object τύπου AthensArea xρησιμοποιείτε ως ώρισμα για την κλήση της GetPharmaciesOnDuty(<strong>AthensArea
                    Area</strong>,AvailableDates Date)
            </p>
        </div>
        <div class="alert alert-info">
            <span class="label label-success">You need this...</span>
            <h3>
                List&ltAvailableDates&gt GetAvailableDates()</h3>
            <div style="margin-top: 10px;">
                <pre>
            <code>AvailableDates[] Dates = client.GetAvailableDates(); </code>
            </pre>
            </div>
            <p>
                Επιστρέφει ένα array από Objects τύπου AvailableDates που αντιπροσωπεύουν τις διαθέσιμες
                ημερομήνιες για τις οποίες επιστρέφονται εφημερεύοντα φαρμακεία.
            </p>
            <p>
                Object τύπου AvailableDates xρησιμοποιείτε ως ώρισμα για την κλήση της GetPharmaciesOnDuty(AthensArea
                Area, <strong>AvailableDates Date</strong>)
            </p>
        </div>
        <div class="alert alert-info">
            <span class="label label-important">This is where the magic happens</span>
            <h3>
                List&ltPharmacyOnDuty&gt GetPharmaciesOnDuty(AthensArea Area, AvailableDates Date)</h3>
            <div style="margin-top: 10px;">
                <pre>
            <code>PharmacyOnDuty[] PharmaciesOnDuty = client.GetPharmaciesOnDuty(Areas[80], Dates[2]);
            </code>
            </pre>
            </div>
            <p>
                Επιστρέφει ένα array από Objects τύπου PharmaciesOnDuty με τα εφημερεύοντα φαρμακεία
                την συγκεκριμένη ημερμηνία για την συγκεκριμένη περιοχή της Αττικής .
            </p>
            <div>
                <table class="table table-striped table-bordered table-condensed">
                    <thead>
                        <th colspan="2">
                            Input Parameters
                        </th>
                        <tr>
                            <th>
                                AthensArea Area
                            </th>
                            <th>
                                AvailableDates Date
                            </th>
                        </tr>
                    </thead>
                    <tr>
                        <td>
                            Object τύπου AthensArea, επιλογή απο το επιστρεφόμενο array της κλήσης της GetAvailableAthensAreas()
                        </td>
                        <td>
                            Object τύπου AvailableDates, επιλογή απο το επιστρεφόμενο array της κλήσης της GetAvailableDates()
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
