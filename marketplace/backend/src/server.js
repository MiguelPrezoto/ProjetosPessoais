const express = require("express");
const cors = require("cors");
const pool = require("./db");

const app = express();
app.use(cors());
app.use(express.json());

app.get("/health", (req, res) => {
    res.json({ ok: true, service: "marketplace-api" });
})

app.get("/db-test", async (req, res) => {
    try {
        const result = await pool.query("SELECT NOW() AS agora");
        res.json({ ok: true, db_time: result.rows[0].agora }); 
    } catch (err) {
        res.status(500).json({ ok: false, error: err.message });
    }
})

app.listen(process.env.PORT || 3001, () => {
    console.log(`API rodando na porta ${process.env.PORT || 3001}`);
})