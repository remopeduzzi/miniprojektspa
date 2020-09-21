import React, {Component} from 'react'
import React from "react";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link
} from "react-router-dom";
import NoteList from './Components/NoteList';
import './App.css';
import DarkmodeSwitch from "./Components/DarkmodeSwitch";



class App extends Component {


  render() {return (
      <div>
         <div className="ApplicationHeader">
            <DarkmodeSwitch isChecked={false} text="" value="" onChangeEventHandler={alert}  />
         </div>
          <Router>
              <Route path="/" component={NoteListPage} />
              <Route path="/notes" component={NoteListPage} />
          </Router>
          <NoteList notes={this.state.notes}/>
      </div>

  )}
  state = {
    notes: []
  }
  componentDidMount() {

    fetch("http://localhost:5000/api/notes")
        .then(response => response.json())
        .then((data) => {this.setState({ notes: data})
        })

  }

}
export default App;
