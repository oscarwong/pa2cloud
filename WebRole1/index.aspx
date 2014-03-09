<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebRole1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css">
    <meta charset="utf-8">
    <title>Search request</title>
    <script type="text/javascript">
        function testJson() {
            var userinput = $("#input").val();
            alert("Please wait for the \"instant\" search results to pop up below...");
            $.ajax({
                type: "POST",
                url: "obtain.asmx/read",
                data: '{_userinput:"' + userinput + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    //alert("Results produced");
                    console.log(msg)
                    $("#result").html(msg.d.toString());
                },
                error: function (xhr, status, error) {
                    var err = eval("(" + xhr.responseText + ")");
                    alert(err.Message);
                }
            });
        };

    </script>
    <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
</head>
<body>
    <div class="row">
        <div class="col-lg-6 col-lg-offset-3">
            <div class="input-group">
                <input type="text" class="form-control" name="input" id="input" value="" />
                <span class="input-group-btn">
                    <button class="btn btn-default" type="button" onclick="testJson()">Go!</button>
                </span>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-2 col-md-offset-5 container">
            <div id="result"></div>
        </div>
    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
</body>
</html>
