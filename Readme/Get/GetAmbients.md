# GetAmbients

**URL** : `/api/Ambients/GetAmbients`

**Method** : `GET`

**Auth required** : NO

**Permissions required** : None

## Success Response

**Condition** : If everything is OK and Server is UP.

**Code** : `200 SUCCESSFUL`

**Content Example**

```json
[
  {
    "ambientID": 25,
    "airQuality": 10,
    "airTemperature": 10,
    "airHumidity": 10,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "ambientID": 26,
    "airQuality": 11,
    "airTemperature": 11,
    "airHumidity": 11,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "ambientID": 27,
    "airQuality": 13,
    "airTemperature": 13,
    "airHumidity": 13,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "ambientID": 28,
    "airQuality": 13,
    "airTemperature": 13,
    "airHumidity": 13,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "ambientID": 29,
    "airQuality": 0,
    "airTemperature": 0,
    "airHumidity": 0,
    "createdDate": "2021-09-16T15:01:52.904Z"
  }
]
```