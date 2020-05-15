import './App.scss';
import React from 'react';
import ToDo from './components/ToDo';

const App = () => {
  return (
    <section className="section">
      <div className="container is-fluid">
        <ToDo />
      </div>
    </section>
  );
}

export default App;
