# styles.css
*, *::before, *::after {
    box-sizing:border-box;
    font-family: Roboto, Arial, Arial, Helvetica, sans-serif;

}

body {
    margin: 0;
}

.video-section {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
    gap: 3rem 1rem;
    padding: 3rem 0;
    margin: 0 1.5rem;
    border-top: 4px solid #CCC;
}

.video-section:first-child {
    border-top: none;
}

.video-container {
    display: flex;
    flex-direction: column;
}

.thumbnail {
    position: relative;
    display: flex;
}

.thumbnail::before {
    content: attr(data-duration);
    position: absolute;
    background-color: rgba(0, 0, 0, .85);
    color: white;
    right:5px;
    bottom: 5px;
    padding: 1em .3em;
    border-radius: .3em;
    font-size: .9rem;
}

.thumbnail-image {
    width: 100%;
    height: 100%;
    min-width: 250px;
    min-height: 150px;
    background-color: #AAA;
}

.video-bottom-section {
    display: flex;
    align-item: flex-start;
    margin-top: 1rem;
}


.channel-icon {
    margin-right: .75rem;
    border-radius: 50%;
    width: 36px;
    height: 36px;
    background-color: #AAA;
}

.video-details {
    display: flex;
    flex-direction: column;
}

.video-title {
    font-size: 1rem;
    font-weight: bold;
    margin-bottom: .5rem;
    text-decoration: none;
    color: black;
}

.video-channel-name {
    margin-bottom: .1rem;
    text-decoration: none;
    color: #555;
}

.video-channel-name:hover {
    color: #111;
}

.video-channel-name,
.video-metadata {
    color: #555;
}

.video-ection-title {
    grid-column: 1 / -1;
    margin: -.5rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0 .5rem;
}

.video-section-title-close {
    border: none;
    background: none;
    padding: 0;
    font-size: 2rem;
    color: #555;
    cursor: pointer;
}

.videos {
    background-color: #F9F9F9;
}

.categorie {
    padding: 1rem 2rem;
    border-top: 1px solid #999;
    border-bottom: 1px solid #999;
}

.category-section {
    display: flex;
    overflow: hidden;
}

.category {
    margin-right: 1rem;
    word-wrap: none;
    white-space: nowrap;
    border: 1px solid #CCC;
    border-radius: 900px;
    background-color: #e7e7e7;
    padding: .5rem 1rem;
    font-size: inherit;
    cursor: pointer;
    transition: background-color 150ms;
}

.category:hover {
    background-color: #DDD;
}

.category.active {
    background-color: #606060;
    color: white;
    border-color: #EEE;
}

.category:last-child {
    margin-right: 0;
}

.header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 1rem;
}

.youtube-logo {
height: 20px;
width: 50px;
}

.search-bar {
    display: flex;
    flex:grow: 1;
    margin: 0 2rem 0 4rem;
}

.search-input {
    width: 100%;
    font-size: inherit;
    padding: 1px solid #777;
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
}

.search-btn {
    dislplay: flex;
    align-items: center;
    padding: 0 1.25rem;
    border: 1px solid #777;
    background-color: #F8F8F8;
    border-left: none;
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
    cursor: pointer;
}

.search-btn:hover {
    background-color: #F0F0F0;
}

.menu-icons {
    display: grid;
    grid-template-columns: repeat(4,auto);
    align-items: center;
    gap: 1.5rem;
}

.menu-channel-icon {
    border-radius: 50%;
    width: 36px;
    height: 36px;
    background-color: #AAA;
}