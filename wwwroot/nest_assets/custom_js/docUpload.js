$("#docUpload").on("change", function () {
  console.log("This is where you show the image lol");
  let image = $("#docUpload")[0].files[0];
  console.log("This is where you show the image lol");
  console.log(image);
  let formdata = new FormData();
  formdata.append("file",image);
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
        'success': (OCRdata) => {
          $("#docErr").html("OCR working for " + OCRdata);
          $("#exampleModal").modal("show");
          $('#exampleModal .modal-body').html("OCR working for " + OCRdata);
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
