using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movimiento : MonoBehaviour


{
    public Transform controladorGolpe;
    public float radioGolpe;
    public float dañoGolpe;
    public Text contadorMonedas;
    public Animator animator;
    public SpriteRenderer sprite;
    public float velocidad;
    public float salto;
    Rigidbody2D rigi;
    private int monedasRecolectadas = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Golpe();
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigi.velocity = new Vector2(velocidad, rigi.velocity.y); //Mover a la derecha 
            transform.eulerAngles = new Vector3(0, 0, 0);
            animator.SetBool("Correr", true);
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))

        {
            rigi.velocity = new Vector2(-velocidad, rigi.velocity.y); //Mover a la izquierda
            transform.eulerAngles = new Vector3(0, 180, 0);
            animator.SetBool("Correr", true);
        }

        else
        {
            rigi.velocity = new Vector2(0, rigi.velocity.y);
            animator.SetBool("Correr", false);
        }

        if (Input.GetKey("space") && detectarsalto.suelo)
        {
            rigi.velocity = new Vector2(rigi.velocity.x, salto);  //Para generar el salto cree un gameobject con un collider en los pies del personaje
                                                                  //para que dectecte cuando esta en el suelo y si esta en el suelo puede saltar, asi se evita el doble salto o salto infinito
        }

        if (detectarsalto.suelo == false)
        {
            
            animator.SetBool("Correr", false);

        }

        
        
        
        

        
       
    }
    // Update is called once per frame
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monedas"))
        {

            Destroy(other.gameObject); 
            monedasRecolectadas++;
            Debug.Log("¡Moneda recolectada!");
            ActualizarContadorUI();
            RevisarMonedasRecolectadas();
        }
        void ActualizarContadorUI()
        {
            // Actualizar el texto UI con la cantidad de monedas recolectadas
            contadorMonedas.text = "Monedas: " + monedasRecolectadas.ToString();
        }

    }

    void RevisarMonedasRecolectadas()
    {
        if (monedasRecolectadas >= 6)
        {
            CambiarEscena();
        }
    }
    void CambiarEscena()
    {
        // Cambia "NombreDeLaSiguienteEscena" por el nombre de la escena que deseas cargar
        SceneManager.LoadScene("win");
    }

    private void Golpe()
    {
        animator.SetTrigger("Attack");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);
        
        foreach(Collider2D colisionador in objetos)
        {
            if(colisionador.CompareTag("Enemigo"))
            {
                
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
}
