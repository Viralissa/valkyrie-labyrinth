using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{

    public class Inventory : MonoBehaviour
    {

        List<Item> item;
        public int Range;
        public GameObject cellContainer;
        public Transform _myposition;
        public KeyCode showInventory;
        public int present = 0;
        public GameObject _present;
        public bool HaveRedkey = false;
        public bool HaveBluekey = false;
        public bool HaveYellowkey = false;

        void Start()
        {
            item = new List<Item>();

            cellContainer.SetActive(false);

            for (int i = 0; i < cellContainer.transform.childCount; i++)
            {
                item.Add(new Item());
            }
        }

        void Update()
        {

            ToggleInventory();
            if (Input.GetKeyDown(KeyCode.F))
            {
                Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, Range))
                {
                    if (hit.collider.GetComponent<Item>())
                    {
                        AddItem(hit.collider.GetComponent<Item>());
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].id == 1)
                    {
                        item[i].countItem--;
                        if (item[i].countItem > 0) { Instantiate(_present, _myposition.transform.position, _myposition.transform.rotation); }
                        DisplayItems();

                    }
                }
            }
        }

        void AddItem(Item currentItem)
        {

            if (currentItem.isStackable)
            {
                AddStackableItem(currentItem);
                present += 1;
            }
            else
            {
                AddUnstackableItem(currentItem);
            }
        }

        void AddUnstackableItem(Item currentItem)
        {
            if (currentItem.id == 2) { HaveBluekey = true; }
            if (currentItem.id == 3) { HaveRedkey = true; }
            if (currentItem.id == 4) { HaveYellowkey = true; }
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == 0)
                {
                    item[i] = currentItem;
                    item[i].countItem = 1;
                    DisplayItems();
                    Destroy(currentItem.gameObject);
                    break;
                }
            }
        }

        void AddStackableItem(Item currentItem)
        {
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].id == currentItem.id)
                {
                    item[i].countItem++;
                    DisplayItems();
                    Destroy(currentItem.gameObject);
                    return;
                }
            }
            AddUnstackableItem(currentItem);
        }

        void ToggleInventory()
        {

            if (Input.GetKeyDown(showInventory))
            {
                if (cellContainer.activeSelf)
                {
                    cellContainer.SetActive(false);
                }
                else
                {
                    cellContainer.SetActive(true);

                }
            }
        }

        void DisplayItems()
        {
            for (int i = 0; i < item.Count; i++)
            {
                Transform cell = cellContainer.transform.GetChild(i);
                Transform icon = cell.GetChild(0);
                Transform count = icon.GetChild(0);

                Text txt = count.GetComponent<Text>();
                Image img = icon.GetComponent<Image>();
                if (item[i].id != 0)
                {

                    img.enabled = true;
                    img.sprite = Resources.Load<Sprite>(item[i].pathIcon);
                    if (item[i].countItem > 1)
                    {
                        txt.text = item[i].countItem.ToString();
                    }
                }
                else
                {
                    img.enabled = false;
                    img.sprite = null;
                    txt.text = null;
                }
            }
        }
    }
}