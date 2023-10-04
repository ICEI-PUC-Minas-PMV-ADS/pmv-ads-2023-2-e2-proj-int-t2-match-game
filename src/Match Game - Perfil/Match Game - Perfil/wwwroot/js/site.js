const alterarImg = document.getElementById('alterarImg');
const modal = document.querySelector('dialog');
const btnCancelar = document.getElementById('btnCancelar');

const alterarUser = document.getElementById('alterarUser');
const modalNome = document.getElementById('modalNome');
const btnCancelarNome = document.getElementById('btnCancelarNome');



alterarImg.onclick = function () {
    modal.showModal()
}

alterarUser.onclick = function () {
    modalNome.showModal();
}

btnCancelar.onclick = function () {
    modal.close()
}

btnCancelarNome.onclick = function () {
    modalNome.close()
}
