'use strict';



// SweetAlert - Error
function showErrorMessage(title = 'Oops...', text = 'Something went wrong!') {
    Swal.fire({
        icon: 'error',
        title: title,
        text: text,
        buttonsStyling: false,
        showConfirmButton: true,
        showCancelButton: false
    })
}


// SweetAlert - Information
function showInfoMessage(title, text) {
    Swal.fire(title, text, 'info')
}


// SweetAlert - Success 
function showSuccessMessage(text = 'Nicely done!') {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 1500,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: text
    })
}


// Reload Page
function reloadPage(time = 1500) {
    setTimeout(
        function () {
            // window.location.reload();
            window.location.href = window.location.href;
        }, time);
}


// SweetAlert - Warning
function showWarningMessage(isConfirmedMethod, title = 'Delete', text = "Are you sure you want to delete it?", confirmButtonText = 'Yes, delete it') {

    Swal.fire({
        title: title,
        text: text,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: confirmButtonText,
        customClass: {
            confirmButton: 'btn btn-primary me-3',
            cancelButton: 'btn btn-label-secondary'
        },
        buttonsStyling: false
    }).then(function (result) {
        if (result.value) {
            isConfirmedMethod();
        }
    });

}

// Clear Errores
function clearFormErrors() {
    let messageBoxs = $("span[class~='field-validation-valid']");
    messageBoxs.map(function () { $(this).html(''); });
}


const Methods = {
    GET: 'GET',
    POST: 'POST',
    DELETE: 'DELETE'
}
// Ajax with Progressbar ( this is a Promise )
function ajaxCall(url, data, type = Methods.POST) {
    return new Promise((resolve, reject) => {


        if (Methods.GET == type) {
            if (data != null) {
            data = convertFormDataToQueryString(data);
            }
        }

        $.ajax({
            url: url,
            type: type,
            contentType: false,
            cache: false,
            processData: false,
            data: data,
            // contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            //dataType: "json",
            xhr: function () {

                var jqXHR = null;
                try {
                    if (window.ActiveXObject) {
                        jqXHR = new window.ActiveXObject("Microsoft.XMLHTTP");
                    }
                    else {
                        jqXHR = new window.XMLHttpRequest();
                    }
                } catch (e) {
                    //  // console.log("error : " + e);
                    jqXHR = new window.XMLHttpRequest();
                }



                //Upload progress
                jqXHR.upload.addEventListener("progress", function (evt) {

                    if (evt.lengthComputable) {
                        var percentComplete = Math.round((evt.loaded * 100) / evt.total);

                        $('#loadingPercent').html(percentComplete + "%");
                    }
                }, false);
                return jqXHR;
            },
            success: function (data) {
                clearFormErrors();
                resolve(data);
            },
            error: function (req, status, error) {
                console.log(req);
                var jsonResult = req.responseJSON;
                if (jsonResult) {
                    clearFormErrors();
                    // نمایش خطا ها
                    jsonResult.forEach(function (item) {
                        var message = item.Message;
                        let target = item.Target;
                        if (target) {
                            if (target != "*") {
                                $(`span[data-valmsg-for=${target}]`).html(message)
                            }
                        }
                    });
                    if (jsonResult.length > 0) {
                        showErrorMessage(jsonResult[0].Message, '');
                    }
                }
                reject(req);
            }
        });

    });
}


// Create a FormDate with all inputs and Files
function formSerializer(formId = 'ajax_Form_General') {

    var data = new FormData();

    $('#' + formId + ' input').each(function () {
        console.log(`type: ${$(this).attr('type')} - name: ${$(this).attr('name')} - value: ${$(this).val()}`);

        // افزودن اینپوت هایی که تایپ فایل ندارند
        if ($(this).attr('type') != "file" && $(this).attr('type') != "checkbox" && $(this).attr('type') != "radio") {
            data.append($(this).attr('name'), $(this).val());

            // افزودن فایل ها
        } else if ($(this).attr('type') == "file") {

            var file = $(this)[0].files;
            for (var i = 0; i < file.length; i++) {
                data.append($(this).attr('name'), file[i]);
            }
        } else if ($(this).attr('type') == "checkbox" || $(this).attr('type') == "radio") {
            if ($(this).prop('checked') == true) {
                data.append($(this).attr('name'), $(this).val());
            }
        }




        //// اعتبار سنجی
        //let dataVal = $(this).attr('data-val');
        //if (dataVal) {
        //    let requierd = $(this).attr('data-val-required');
        //    if (requierd) {
        //        if ($(this).val() == "") {
        //            $(`span[data-valmsg-for=${$(this).attr('name')}]`).html(requierd);
        //        }
        //    }
        //}



    });
    // select tags
    $('#' + formId + ' select').each(function () {
        data.append($(this).attr('name'), $(this).val());

        // اعتبار سنجی
        let dataVal = $(this).attr('data-val');
        if (dataVal) {
            let requierd = $(this).attr('data-val-required');
            if (requierd) {
                if ($(this).val() == "") {
                    $(`span[data-valmsg-for=${$(this).attr('name')}]`).html(requierd);
                }
            }
        }
    });


    $('#' + formId + ' textarea').each(function () {
        // console.log(`textarea -> name: ${$(this).attr('name')} - value: ${$(this).val()}`);
        data.append($(this).attr('name'), $(this).val());

        // اعتبار سنجی
        let dataVal = $(this).attr('data-val');
        if (dataVal) {
            let requierd = $(this).attr('data-val-required');
            if (requierd) {
                if ($(this).val() == "") {
                    $(`span[data-valmsg-for=${$(this).attr('name')}]`).html(requierd);
                }
            }
        }
    });
    return data;
}

// For FormData
function convertObjectToFormData(obj) {

    var form_data = new FormData();

    for (var key in obj) {
        form_data.append(key, obj[key]);
        console.log(`(key : ${key} ) : (value : ${obj[key]})`)
    }
    console.log(obj);
    console.log(form_data);
    return form_data;
}
function convertObjectToQueryString(obj) {
    var str = [];
    for (var p in obj)
        if (obj.hasOwnProperty(p)) {
            str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
        }
    console.log(str.join("&"));
    return str.join("&");
}

function convertFormDataToQueryString(formData) {
    return new URLSearchParams(formData).toString();
}




// Show Modal
function showModal(body, title, description = '', size = 'md') {

    let modalSize = $('#modalCustomSize');
    let modalTitle = $('#modalCustomTitle');
    let modalDescription = $('#modalCustomDescription');
    let modalBody = $('#modalCustomBody');
    let modal = $('#modalCustomTarget');

    modalSize.addClass(`modal-${size}`);
    modalTitle.html(title);
    modalDescription.html(description);
    modalBody.html(body);
    modal.modal('show');
}

function closeModal() {
    $('#dataBsDismissModal').click();
}

function select2Search(className, url) {

    $(`.${className}`).select2({
        ajax: {
            url: url,
            data: function (params) {
                console.log(params);
                return {
                    q: params.term // search term
                };
            },
            processResults: function (data) {
                try {
                    return {
                        results: data
                    };
                } finally {

                }
            },
        }
    });
}


function select2Client(className, url) {

    let select2Element = $(`.${className}`);

    ajaxCall(url, null, Methods.GET)
        .then(data => {
            console.log(data);
            select2Element.html('');
            data.forEach((i) => { select2Element.append(` <option value="${i.id}">${i.text}</option>`) });
            //data.each(function (i) {
            //    select2Element.append(` <option value="${i.id}">${i.text}</option>`)
            //});

        }).finally(() => {
            select2Element.select2({
                placeholder: "Select a state"
            });
        });


}

function select2ClientWithThis(ts, url) {

    let select2Element = $(ts);

    ajaxCall(url, null, Methods.GET)
        .then(data => {
            console.log(data);
            select2Element.html('');
            data.forEach((i) => { select2Element.append(` <option value="${i.id}">${i.text}</option>`) });
            //data.each(function (i) {
            //    select2Element.append(` <option value="${i.id}">${i.text}</option>`)
            //});

        }).finally(() => {
            select2Element.select2({
                placeholder: "Select a state",
                allowClear: true
            });
        });


}
function forSelect(item, index) {

}

function refreshImage(image) {
    let src = $(image).attr('src');
    let getTime = new Date().getTime();
    $(image).attr('src', `${src}?time=${getTime}`);
}