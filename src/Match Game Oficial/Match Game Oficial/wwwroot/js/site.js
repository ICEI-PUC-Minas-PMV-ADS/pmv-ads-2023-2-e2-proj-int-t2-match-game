/* API */
const APIKEY = "69f74f8a6cde46529c5d0923786cdab7"
const loaderEl = document.getElementById("js-preloader");
const gameList = document.querySelector(".gameList");
const loadMoreGamesBtn = document.querySelector(".main-button");
let nextGameListUrl = null;


const url = `https://api.rawg.io/api/games?key=${APIKEY}`


const getPlatformStr = (platforms) => {
    const platformStr = platforms.map(each => each.platform.name).join(",");
    if (platformStr.length > 30) {
        return platformStr.substring(0, 30) + "...";
    }
    return platformStr

}
function loadGames(url) {
    loaderEl.classList.remove("loaded");

    fetch(url)
        .then(response => response.json())
        .then(data => {

            nextGameListUrl = data.next ? data.next : null;
            const games = data.results;
            loaderEl.classList.add("loaded")


            games.forEach(game => {

                const gameItemEl =
                    `

                  <div class="col-lg-3 col-sm-6 col-md-4 col-sm-6 col-xl-3">
                        <div class="item position-relative card">
                            <div class="gameImg">
                                <img src="${game.background_image}" alt="${game.name} image" style="width: 100%; ">
                            </div>
                            <div id="favoritos favorite-button">
                                <i id="favIcon" class="fa-regular fa-heart favoritos position-absolute  top-90 end-0 b-24 favorite-button" style="color: #8952ff;" title="Favoritar"></i>
                            </div>

                            <h4 class="game-name">${game.name}<br>
                                 <span class="platforms">${getPlatformStr(game.parent_platforms)}</span>
                            </h4>
                           
                            <div class="info">
                                <ul class="infoGeral">
                                    <li><i class="fa-solid fa-star" style="color: #ffc800;"></i> <span class="rating">${game.rating}</span></li>
                                    <li><i class="fa-regular fa-calendar" style="color: #ffc800;"></i> <span class="date">${game.released}</span></li>
                                </ul>
                            </div>
                            <div class="text-center saibaMaisBtn">
                                  <button class="btn btnSaibaMais">SAIBA MAIS</button>

                            </div>
                        </div>
                    </div>

                `
                gameList.insertAdjacentHTML("beforeend", gameItemEl);
            });

            if (nextGameListUrl) {
                loadMoreGamesBtn.classList.remove("hidden");
            } else {
                loadMoreGamesBtn.classList.add("hidden");
            }
        })
        .catch(error => {
            console.log("Ocorreu algum erro", error);
        });
}

loadGames(url);

loadMoreGamesBtn.addEventListener('click', () => {
    if (nextGameListUrl) {
        loadGames(nextGameListUrl);
    }
});

