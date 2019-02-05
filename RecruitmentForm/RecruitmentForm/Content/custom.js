$(document).ready(function () {
    var practiceId = $("#practice");
    var nameId = $("#candidate-name");
    var table = $("#Employees");
    nameId.empty().append('<option selected="selected" value="Select Name">Select Name</option>');
    var jsonObject = {};
    $.ajax({
        type: "POST",
        url: "WorkFlow.asmx/GetAllPractices",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var data = response.d;
            // jsonObject = data;
            $.each(JSON.parse(data), function (key, value) {
                practiceId.append('<option value=' + key + '>' + value + '</option>');
            });

        },
        error: function (response) {
            alert("Error");
        }
    });


    practiceId.change(function () {
        var val = practiceId.val();
        if (val == "Select Practice") {
            return false;
        }
        nameId.empty().append('<option selected="selected" value="Select Name">Select Name</option>');
        LoadNames();


    });

    //nameId.click(function () {
    //    if (practiceId.val() == "Select Practice") {
    //        alert("Please Select Practice First");
    //        nameId.val("Select Name");
    //        return false;
    //    }
    //    var obj = {};
    //    obj = jsonObject[nameId.val()];
    //    $("#txtname").val(obj.name);
    //});

    function LoadNames() {
        var selectedText = $("#practice option:selected").html();
        var jsonPractice = {
            "practice": selectedText
        };
        $.ajax({
            type: "POST",
            url: "WorkFlow.asmx/GetAllEmployees",
            dataType: "json",
            async: "false",
            data: jsonPractice,
            success: function (response) {
                jsonObject = response;
                //$.each(jsonObject, function (key, value) {
                //    nameId.append('<option value=' + key + '>' + value.Name + '</option>');

                //});
                LoadDataTable(jsonObject);
            },
            error: function (response) {
                alert("Error");
            }

        });
    }

    //Load Datatable using Json Data
    function LoadDataTable(jObject) {

        table.DataTable({
            "lengthMenu": [[5, 10, 50, -1], [5, 10, 50, "All"]],
            "sPaginationType": "simple",
            "aaData": jObject,
            "destroy": true,

            columns: [
                {
                    data: "Name",
                    render: function (data, type, row, meta) {
                        return meta.row + meta.settings._iDisplayStart + 1;
                    }
                },
                {
                    data: "Name",
                },
                
                {
                    data: "Position",
                },
                {
                    data: "Email",
                },
                {
                    data: "Phone",
                },
                {
                    data: "Email",
                    render: function (data) {

                        return "<button  value='" + data + "' class='btn btn-link font-weight-bold initiate-employee'>Initiate</button> ";
                    }
                },
                {
                    data: "Name",
                    render: function (data) {

                        return " ";
                    }
                }

            ]
        });

    }
    //Handle click event
    $('#Employees tbody').on('click', 'td button', function (event) {
        event.preventDefault();
        var RowIndex = $(this).closest('tr').index();
        var eml = this.value;
        var name;
        var practice;
        var phone;
        var index = 0;
        for (row in jsonObject) {
            if (jsonObject[row].Email == eml) {
                name = jsonObject[row].Name;
                practice = jsonObject[row].Practice;
                phone = jsonObject[row].Phone;
                index = row;
            }
        }
        if (!confirm("Please confirm the approval\n" + "Name : " + name + "\n" + "Email : " + eml + "\n" + "practice : " + practice)) {
            return false;
        }
        var status = StartMicrosoftFlowTriggerOperations(eml, name, phone, practice);
        if (status) {
            var thiss = $(this);
            thiss.text("Started");
            thiss.css("color", "green");
            thiss.prop("disabled", true);
        }
    });



    ////This method attaches click event to input button.
    //$("#start-flow").click(function () {
    //    if (!confirm("Are you sure")) {
    //        return false;
    //    }
    //    StartMicrosoftFlowTriggerOperations();
    //});

    //This method triggers the microsoft flow  
    function StartMicrosoftFlowTriggerOperations(eml, name, phone, practice) {
        var trick = false;
        return true;
        try {
            var dataTemplate = "{\r\n    \"emailaddress\":\"{0}\",\r\n     \"name\":\"{1}\",\r\n    \"phone\": \"{2}\",\r\n    \"practice\": \"{3}\"\r\n}";
            var httpPostUrl = "https://prod-12.westus.logic.azure.com:443/workflows/789e534ad3ab49c8abc72ae70caf5da0/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=-hL0T5lQeDY8jv-U8m2tqeuFdRPL9VKyrJzAPKlOFpA";
            //New Link : https://prod-44.westus.logic.azure.com:443/workflows/3a5e920b3ff348bbae3a916cfbdd7101/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=mJ84rr7jxOUmQRsupS_eI7Lk9AweHYuhJCfMFUlVtI8
            //Call FormatRow function and replace with the values supplied in input controls.
            dataTemplate = dataTemplate.FormatRow(eml, name, phone, practice);
            $.ajax({
                url: httpPostUrl,
                async: false,
                crossDomain: "true",
                type: "POST",
                headers: {
                    "content-type": "application/json",
                    "cache-control": "no-cache"
                },
                processData: false,
                data: dataTemplate,
                success: function (response) {
                    trick = true;
                },
                error: function (response) {
                }

            });
            //var settings = {
            //    "async": true,
            //    "crossDomain": true,
            //    "url": httpPostUrl,
            //    "method": "POST",
            //    "headers": {
            //        "content-type": "application/json",
            //        "cache-control": "no-cache"
            //    },
            //    "processData": false,
            //    "data": dataTemplate
            //}

            //$.ajax(settings).done(function (response) {
            //    console.log("Successfully triggered the Microsoft Flow. ");
            //});
        }
        catch (e) {
            console.log("Error occurred in StartMicrosoftFlowTriggerOperations " + e.message);
        }

        return trick;
    }

    //This method formats the rowTemplate by replacing the placeholders based on the arguments passed.  
    String.prototype.FormatRow = function () {
        try {
            var content = this;
            for (var i = 0; i < arguments.length; i++) {
                var replacement = '{' + i + '}';
                content = content.replace(replacement, arguments[i]);
            }
            return content;
        }
        catch (e) {
            console.log("Error occurred in FormatRow " + e.message);
        }
    }
});