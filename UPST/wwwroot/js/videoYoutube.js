document.addEventListener("load", fetchVideo());

async function fetchVideo() {
  const videosYT = document.querySelector(".videos-yt");

  const channelID = "UCJdhhKZejU6CnBa1l33DHpw";
  const API_Key = "AIzaSyB9EhCaZEZQFYvtveSKQ9MYn-r50IvnBuI";
  const maxResults = 3;

  await fetch(
    `https://youtube.googleapis.com/youtube/v3/search?part=snippet&channelId=${channelID}&maxResults=${maxResults}&order=date&key=${API_Key}`
  )
    .then((response) => response.json())
    .then((datas) => {
      try {
        // Change number month into Text Month
        function getMonthName(monthNumber) {
          const date = new Date();
          date.setMonth(monthNumber - 1);

          return date.toLocaleString("id-ID", {
            month: "long",
          });
        }

        // console.log(datas.items);
        datas.items.forEach((data, index) => {
          const date = data.snippet.publishTime.split("-");
          const day = date[2].slice(0, 2);
          const month = getMonthName(date[1]);
          const year = date[0];
          console.log("Tanggal = ", day, month, year);

          console.log(data);
          // console.log(index, data.id.videoId);
          // console.log(data.snippet.title);
          // console.log(data.snippet.description);
          // console.log(data.snippet.thumbnails.medium.url);

          videosYT.innerHTML += `
        <div class="col-md-4 py-4">
          <a href='https://www.youtube.com/watch?v=${data.id.videoId}'>
            <img
              src=${data.snippet.thumbnails.medium.url}
              class="rounded-4 thumbnail-fit"
              width="100%"
              height="250px"
              alt=""
            />
          </a>
          <div class="mt-3 px-3">
            <a href='https://www.youtube.com/watch?v=${data.id.videoId}' class="text-dark text-decoration-none">
              <h2 class="mb-1 fw-semibold fs-4 text-break line-clamp-2">
                ${data.snippet.title}
              </h2>
            </a>
            <span class="text-muted fs-6">
              <a href="https://www.youtube.com/@unitpengelolasampahterpadu707" class="text-secondary text-decoration-none"
                >UPST DLH</a
              >
              • ${day} ${month} ${year}</span
            >
            </div>
        </div>
        `;
        });
      } catch (err) {
        console.log(err);
      }
    });
}

// Format URL Video = https://www.youtube.com/watch?v=pj4QCHDGiiY
