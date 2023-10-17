using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class New_script : MonoBehaviour
{
    public Color newColor;
    public float speed;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        rend.material.color = newColor;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

public class Counter : MonoBehaviour
{
    public int counterValue = 10; // Изначальное значение счетчика
    public Text counterText; // Ссылка на компонент Text, на котором будет отображаться значение счетчика

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            counterValue--; // Уменьшаем значение счетчика при столкновении
            UpdateCounterText(); // Обновляем отображение текста счетчика
        }
    }

    private void UpdateCounterText()
    {
        counterText.text = "Counter: " + counterValue.ToString(); // Обновляем текст счетчика
    }
}
