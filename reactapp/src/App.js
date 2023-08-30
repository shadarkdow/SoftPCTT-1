import { useEffect, useState } from 'react';
import './App.css';

function App() {
  const [data, setData] = useState([])

  useEffect(() => {
    fetch('http://localhost:5160/api/member')
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.log(error))
  })
  console.log(data)

  return (
    <div className="App">
      <header className="App-header">
        <div className="card">
          <div className="card-container">
            <img className='card-img' src="../logo192.png" alt="Avatar" />
            <h4 className='card-header'>John Doe</h4> 
            <p className='card-text'>Architect & Engineer</p> 
          </div>
        </div>
      </header>
    </div>
  );
}

export default App;
