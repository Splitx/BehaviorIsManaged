﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using BiM.Game.Actors.RolePlay;
using BiM.Protocol.Enums;
using BiM.Protocol.Messages;

namespace BiM.Game.Items
{
    public class Inventory : INotifyPropertyChanged
    {
        public Inventory(PlayedCharacter owner)
        {
            Owner = owner;
            Items = new ObservableCollection<Item>();
        }

        public Inventory(PlayedCharacter owner, InventoryContentMessage inventory)
        {
            if (owner == null) throw new ArgumentNullException("owner");
            if (inventory == null) throw new ArgumentNullException("inventory");
            Owner = owner;
            Items = new ObservableCollection<Item>(inventory.objects.Select(entry => new Item(entry)));
            Kamas = inventory.kamas;
        }

        public PlayedCharacter Owner
        {
            get;
            set;
        }

        public ObservableCollection<Item> Items
        {
            get;
            set;
        }

        public int Kamas
        {
            get;
            set;
        }

        public bool HasItem(int guid)
        {
            return false;
        }

        public Item GetItem(int guid)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(CharacterInventoryPositionEnum position)
        {
            throw new NotImplementedException();
        }

        public Item[] GetEquipedItems()
        {
            throw new NotImplementedException();
        }

        public bool Equip(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Move(Item item, CharacterInventoryPositionEnum position)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Drop(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Use(Item item)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}