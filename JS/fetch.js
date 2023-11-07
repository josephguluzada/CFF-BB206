// fetch("https://api.tvmaze.com/shows")
//     .then(response => response.json())
//     .then(datas => {

//         for (let i = 0; i < datas.length; i++) {
//             let filmContainer = document.createElement("div");
//             let image = document.createElement("img");
//             let h4 = document.createElement("h4");
//             let h3 = document.createElement("h3")
//             let a = document.createElement("a");
//             filmContainer.style.width = "220px"
//             filmContainer.style.border = "1px solid black"
//             h3.innerText = datas[i].language;
//             h4.innerText = datas[i].name
//             a.innerText = "go to site"
//             a.setAttribute("href", datas[i].officialSite)
//             image.setAttribute("src", datas[i].image.medium)

//             filmContainer.appendChild(image)
//             filmContainer.appendChild(h4)
//             filmContainer.appendChild(h3)
//             filmContainer.appendChild(a)

//             document.body.appendChild(filmContainer)

//         }

//     })
// `https://api.tvmaze.com/shows/${id}`
let row = document.getElementById("filmRow");

axios.get("https://api.tvmaze.com/shows")
  .then(datas => {
    console.log(datas.data);

    datas.data.forEach(film => {
      row.innerHTML += `
            <div class="col-md-3">
                <div class="card" style="width: 18rem;">
                    <img src="${film.image.medium}" class="card-img-top" alt="...">
                    <div class="card-body">
                      <h5 class="card-title">${film.name}</h5>
                      <p class="card-text">${film.language}</p>
                    </div>
                    <ul class="list-group list-group-flush">
                      <li class="list-group-item">${film.premiered}</li>
                      <li class="list-group-item">IMDB: ${film.rating.average}</li>
                      <li class="list-group-item">A third item</li>
                    </ul>
                    <div class="card-body">
                      <a href="${film.officialSite}" class="card-link">Film link</a>
                      <a href="http://127.0.0.1:5500/detail.html?${film.id}" class="card-link">Film detail</a>
                    </div>
                  </div>
            </div>
            `
    });

  })