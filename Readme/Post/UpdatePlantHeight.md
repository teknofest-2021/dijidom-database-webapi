# UpdatePlantHeight

Push Data which came from RasperyPI to Database

**URL** : `/api/Plants/UpdatePlantHeight`

**Method** : `POST`

**Auth required** : NO

**Permissions required** : None

## Parameters
* plantID
* plantHeight

## Success Response

**Condition** : If everything is OK and Server is UP.

**Code** : `200 SUCCESSFUL`

**Content Example**

```json
{
  "data": {
    "plantID": 1,
    "plantName": "Bodur çeri",
    "typeID": 1,
    "plantHeight": 8.5
  },
  "message": "Updated successfully"
}
```

## Error Responses

**Condition** : If any database error. (May caused by dataString)

**Code** : `200 SUCCESSFUL`

```json
{
  "data": {
    "plantID": 0,
    "plantName": null,
    "typeID": 0,
    "plantHeight": 0
  },
  "message": "Update failed"
}
```

```json
{
  "data": {
    "plantID": 0,
    "plantName": null,
    "typeID": 0,
    "plantHeight": 0
  },
  "message": "Plant height cannot be less than 0."
}
```