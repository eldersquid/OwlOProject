$("#docUpload").on("change", function () {
  let doc = $("#docUpload")[0].files[0];
  console.log(doc);
  let formdata = new FormData();
  formdata.append("file",doc);
  $.ajax({
    url: "/vision/upload",
    type: "POST",
    data: formdata,
    contentType: false,
    processData: false,
    'success': (data) => {
      $("#docErr").html("<b>" + data + "</b> has been uploaded.");
      $.ajax({
        url: "/vision/capture",
        type: "POST",
        data: {"fileName" : data},
        'success': (details) => {
          $("#docErr").html("OCR working for " + details);
          for (var detail in details){
            console.log(detail);
          }
          $("#exampleModal").modal("show");
          document.getElementById('Input_Email').value = details["email"];
          document.getElementById('Input_NRIC').value = details["nric"];
          document.getElementById('Input_Bio').value = details["address"];
          document.getElementById('Input_Name').value = details["name"];
          if (details["gender"] == "M")
          {
            document.getElementById('male').checked = true;
          }
          else
          {
            document.getElementById('female').checked = true;
          }
          $('#exampleModal .modal-body').html("Document Scan Complete.");
          $('#exampleModal .modal-body').html("Document Scan Complete.");
          if (data.err) {
            $("#docErr").show();
            $("#docErr").text(data.err.message);
          } else {
            $("#docErr").show();
          }
        },
      });
      if (data.err) {
        $("#docErr").show();
        $("#docErr").text(data.err.message);
      } else {
        $("#docErr").show();
      }
    },
  });
});
