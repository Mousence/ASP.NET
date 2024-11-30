
import './App.css';
import Header from '../header/Header';
import Nav from '../nav/Nav'
import Power from '../power/Power';
import Article from '../article/Article';
import Footer from '../footer/Footer';
import Fibonacci from '../../fibonacci/Fibonacci';
import data from '../article/db.json';
import Switch from '../switch/Switch'

function App() {

  let nav = 
  {
    "Главная" :   "/index",
    "Новости" :   "/new",
    "Магазин" :   "/shop",
    "О нас"   :   "/about",
    "Контакты":   "/contacts",
  }

  return (
    <div className="App">
      <Header title="Hello React" description="This is my first React App. This phrase passed using parameters over 'PROPS'" />
      <Nav navigation={nav} />
      <Power a={2} n={8} />
      {/* <Fibonacci n={10}/> */}
      <Article db={data}/>
      <Switch/>
      <Footer year="2024"/>
    </div>
  );
}

export default App;
