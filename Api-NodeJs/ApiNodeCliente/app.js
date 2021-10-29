const express = require ('express')
const morgarn = require ('morgan')
const cors = require ('cors')
const bodyParse = require ('body-parser')
const routes = require ('./config/routes.js')

const server = express();

server.use(morgarn('dev'))
server.use(bodyParse.urlencoded({extended : false}))
server.use(express.json())
server.use(cors())
server.use(routes)

server.listen(3030, () => {
    console.log('Express started at http://localhost:3030')
})