.places {
  width: 100%;
  display: flex;
  display: -webkit-flex;
  display: -ms-flexbox;
  flex-wrap: wrap;
  justify-content: center;
  margin-top: 0.5rem;
}

.places h1 {
  font-size: 1.9rem;
  text-align: left;
  width: 100%;
}

.places article {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  width: 390px;
  padding: 20px;
  margin: 20px;
  border: solid #ff5a5f 1px;
  border-radius: 4px;
  vertical-align: top;
}

.places article div {
  width: 100%;
}

.places article h2 {
  font-size: 30px;
  align-self: flex-start;
  margin: 0 auto;
}

.places article .price_by_night {
  color: #ff5a5f;
  border: 4px solid #ff5a5f;
  border-radius: 50%;
  min-width: 60px;
  height: 60px;
  font-size: 1.5rem;
  align-self: flex-start;
  padding: 0.2rem;
  width: auto;
  margin-bottom: 5px;
  display: flex;
  justify-content: center;
  align-content: center;
  align-items: center;
}

.places article .information {
  height: 5.5em;
  border-top: solid #dddddd 1px;
  border-bottom: solid #dddddd 1px;
  display: flex;
  justify-content: center;
  align-content: center;
}

.places article .information .max_guest,
.places article .information .number_rooms,
.places article .information .number_bathrooms {
  width: 100px;
  text-align: center;
  display: inline-block;
  align-self: center;
}

.places article .information .max_guest .icon,
.places article .information .number_rooms .icon,
.places article .information .number_bathrooms .icon {
  width: 100%;
  height: 50px;
  display: inline-block;
  background-repeat: no-repeat;
  background-size: contain;
  background-position: center;
  margin: 0;
}

.places article .information .max_guest .icon {
  background-image: url(../images/icon_group.png);
}

.places article .information .number_rooms .icon {
  background-image: url(../images/icon_bed.png);
}

.places article .information .number_bathrooms .icon {
  background-image: url(../images/icon_bath.png);
}

.places article .user {
  text-align: left;
  margin: 10px 0;
}

.places article .description {
  text-align: left;
}

.places article .amenities,
.places article .reviews {
  text-align: left;
  margin-top: 40px;
}

.places article .amenities h2,
.places article .reviews h2 {
  display: block;
  font-size: 16px;
  text-align: left;
  border-bottom: solid #dddddd 1px;
  margin-top: 0;
  margin-bottom: 10px;
}

.places article .amenities ul,
.places article .reviews ul {
  list-style: none;
  margin: 0;
  padding: 0;
}

.places article .amenities ul li span {
  height: 20px;
  width: 20px;
  display: inline-block;
  background-repeat: no-repeat;
  background-size: contain;
  background-position: center;
  margin: 0 0.2rem 0 0;
  vertical-align: middle;
}

.places article .amenities ul li {
  margin-top: 3px;
}

.places article .amenities ul li span.pet-icon {
  background-image: url(../images/icon_pets.png);
}

.places article .amenities ul li span.tv-icon {
  background-image: url(../images/icon_tv.png);
}

.places article .amenities ul li span.wifi-icon {
  background-image: url(../images/icon_wifi.png);
}

.places article .reviews ul li h3 {
  font-size: 14px;
}

.places article .reviews ul li p {
  font-size: 12px;
}

@media screen and (max-width: 411px) {
  .places article {
    width: 100%;
  }

  .places article h2 {
    font-size: 1.4rem;
  }

  .places article .information .max_guest .icon,
  .places article .information .number_rooms .icon,
  .places article .information .number_bathrooms .icon {
    height: 35px;
  }

  .places article .price_by_night {
    min-width: 43px;
    height: 43px;
    font-size: 1.2rem;
    padding: 0.2rem;
    border-width: 2px;
  }
}

@media screen and (max-width: 411px) {
  .places h1 {
    font-size: 1.6rem;
  }

  .places article .information .max_guest .icon,
  .places article .information .number_rooms .icon,
  .places article .information .number_bathrooms .icon {
    height: 30px;
  }

  .places article .amenities,
  .places article .reviews {
    margin-top: 1.5em;
  }
}
