
/* Modal */
document.addEventListener('DOMContentLoaded', function () {
    var modal = document.querySelector('#modal');
    var btnFechar = document.querySelector('#btnFechar');
    var btnSaibaMais = document.querySelectorAll('.btnSaibaMais');

    btnFechar.addEventListener('click', function () {
        modal.close();
    });

    btnSaibaMais.forEach(function (button) {
        button.addEventListener('click', function () {
            var name = button.getAttribute('data-name');
            var releaseDate = button.getAttribute('data-release-date');
            var storyline = button.getAttribute('data-storyline');

            document.getElementById('modalFirstReleaseDate').textContent = releaseDate; //Atualiza o contéudo do paragrafo com id=modalFirstReleaseDate de acordo com o valor do releaseDate do game da API (Data de Lançamento)
            document.getElementById('modalStoryline').textContent = storyline;  //Atualiza o contéudo do paragrafo com id=modalStoryline de acordo com o valor do storyline do game da API (Resumo)

            modal.showModal();
        });
    });
});

/* Favoritos */

const favoritos = document.getElementById('favoritos')
const favIcon = document.getElementById('favIcon')

let favorito = true;

favoritos.addEventListener('click', function () {
    if (favorito) {
        favIcon.className = "fa-solid fa-heart favoritos position-absolute top-60 end-0"
    }

    else {
        favIcon.className = "fa-regular fa-heart favoritos position-absolute top-60 end-0"
    }

    favorito = !favorito;
});



