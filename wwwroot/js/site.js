var toastElList = [].slice.call(document.querySelectorAll('.toast'));
var options = {
    animation: true,
    /*autohide: false,*/
    delay: 4000
};

var toastList = toastElList.map(function (toastEl) {
    return new bootstrap.Toast(toastEl, options)
});

// * * * ARCHIVADO * * * //
var toastArchivado = document.getElementById('archivadoToast');
if (localStorage.getItem('archivadoReciente')) {
    var toast = new bootstrap.Toast(toastArchivado);
    toast.show();
    localStorage.removeItem('archivadoReciente');
}

$(".archivado").click(function () {
    localStorage.setItem('archivadoReciente', true);
});

// * * * DESARCHIVADO * * * //
var toastDesarchivado = document.getElementById('desarchivadoToast');
if (localStorage.getItem('desarchivadoReciente')) {
    var toast = new bootstrap.Toast(toastDesarchivado);
    toast.show();
    localStorage.removeItem('desarchivadoReciente');
}

$(".desarchivado").click(function () {
    localStorage.setItem('desarchivadoReciente', true);
});