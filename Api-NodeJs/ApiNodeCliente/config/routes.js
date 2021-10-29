const express = require('express')
const routes = express.Router()

let db = [
    {'1' : {Nome : 'Rodrigo', Idade : '20'}}
    ,{'2' : {Nome : 'Marcelo', Idade : '30'}}
    ,{'3' : {Nome : 'Bruno', Idade : '19'}}
    ,{'4' : {Nome : 'Diogo', Idade : '26'}}
]

routes.get('/p', (req, res) =>{
    return res.json(db)
})

routes.get('/p/:id', (req, res) =>{
    const id = req.params.id
    return res.json(db[id])
})

routes.post('/p', (req, res) =>{
    const body = req.body

    if(!body)
        return res.status(400).end()
    
    db.push(body)
    return res.json(body)
})

routes.delete('/p/:id', (req, res) =>{
    let { id } = req.params
    db.splice(id, 1);
    return res.json({message: "Deletado"})
})

module.exports = routes