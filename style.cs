* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    background-color: #0f172a;
    color: white;
    padding: 20px;
}

header {
    text-align: center;
    padding: 20px 0;
}

.logo {
    font-size: 2rem;
    font-weight: 800;
}

.logo span {
    color: #38bdf8;
}

main {
    max-width: 800px;
    margin: auto;
}

.admin-panel {
    background: #1e293b;
    padding: 20px;
    border-radius: 15px;
    margin-bottom: 40px;
    box-shadow: 0 10px 15px -3px rgba(0, 0, 0, 0.1);
}

input, textarea {
    width: 100%;
    padding: 12px;
    margin: 10px 0;
    background: #334155;
    border: none;
    border-radius: 8px;
    color: white;
}

#postBtn {
    width: 100%;
    padding: 12px;
    background: #38bdf8;
    border: none;
    border-radius: 8px;
    font-weight: bold;
    cursor: pointer;
}

.grid {
    display: grid;
    gap: 20px;
}

.card {
    background: white;
    color: #1e293b;
    padding: 20px;
    border-radius: 12px;
    border-left: 5px solid #38bdf8;
}

.card h3 {
    margin-bottom: 10px;
}

.card .date {
    font-size: 0.8rem;
    color: #64748b;
    display: block;
    margin-top: 10px;
}
