import React, { Component } from 'react';

export class TestowaStrona extends Component {
  static displayName = "Testowa S trona";

  render() {
    return (
      <div>
            <h1>Add new card admin</h1>
            <form >
                <div>
                    <label htmlFor="NameCard">Name:</label>
                    <input
                        type="text"
                        id="NameCard"
                        name="NameCard"
                        maxLength="128"
                       
                    />
                </div>
                <div>
                    <label htmlFor="Cost">Cost:</label>
                    <input
                        type="number"
                        id="Cost"
                        name="Cost"
                        
                    />
                </div>
                <div>
                    <label htmlFor="AttackDamage">Attack Damage:</label>
                    <input
                        type="number"
                        id="AttackDamage"
                        name="AttackDamage"
                       
                    />
                </div>
                <div>
                    <label htmlFor="Hp">HP:</label>
                    <input
                        type="number"
                        id="Hp"
                        name="Hp"
                       
                    />
                </div>
                <button type="submit">Submit Card</button>
            </form>
       </div>
    );
  }
}
