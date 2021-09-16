# GetSoils

**URL** : `​/api​/Plants​/GetSoils`

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
    "soilID": 23,
    "soilHumidity": 10,
    "soilTemperature": 10,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "soilID": 24,
    "soilHumidity": 11,
    "soilTemperature": 11,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "soilID": 25,
    "soilHumidity": 13,
    "soilTemperature": 13,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "soilID": 26,
    "soilHumidity": 13,
    "soilTemperature": 13,
    "createdDate": "2021-09-16T15:01:52.904Z"
  },
  {
    "soilID": 27,
    "soilHumidity": 0,
    "soilTemperature": 0,
    "createdDate": "2021-09-16T15:01:52.904Z"
  }
]
```