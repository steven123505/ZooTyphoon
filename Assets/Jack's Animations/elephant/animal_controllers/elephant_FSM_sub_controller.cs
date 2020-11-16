using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elephant_FSM_sub_controller : StateMachineBehaviour
{
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        int temp = animator.GetInteger("activation_number");
        if(temp == 0)
        {
            GameObject.Find("/palm_water0/palm_base/palm_base0").GetComponent<TimelineController0>().Play();
            GameObject.Find("/palm_water0/Cube/Cube_004").GetComponent<move_water0>().Move();
            GameObject.Find("tree_palm0").GetComponent<trigger0_palm>().Move();
            GameObject.Find("palm_water0").GetComponent<base_move0>().Move();
            animator.SetInteger("activation_number", -1);
        }
        if(temp == 1)
        {
            GameObject.Find("/palm_water1/palm_base/palm_base1").GetComponent<TimelineController1>().Play();
            GameObject.Find("/palm_water1/Cube/Cube_004").GetComponent<move_water1>().Move();
            GameObject.Find("tree-palm1").GetComponent<trigger1_palm>().Move();
            GameObject.Find("palm_water1").GetComponent<base_move1>().Move();
            animator.SetInteger("activation_number", -1);
        }
        if(temp == 2)
        {
            GameObject.Find("/palm_water2/palm_base/palm_base2").GetComponent<TimelineController2>().Play();
            GameObject.Find("/palm_water2/Cube/Cube_004").GetComponent<move_water2>().Move();
            GameObject.Find("tree-palm2").GetComponent<trigger2_palm>().Move();
            GameObject.Find("palm_water2").GetComponent<base_move2>().Move();
            animator.SetInteger("activation_number", -1);
        }
        if(temp == 3)
        {
            GameObject.Find("/palm_water3/palm_base/palm_base3").GetComponent<TimelineController3>().Play();
            GameObject.Find("/palm_water3/Cube/Cube_004").GetComponent<move_water3>().Move();
            GameObject.Find("tree-palm3").GetComponent<trigger3_palm>().Move();
            GameObject.Find("palm_water3").GetComponent<base_move3>().Move();
            animator.SetInteger("activation_number", -1);
        }
        if(temp == 4)
        {
            GameObject.Find("/palm_water4/palm_base/palm_base4").GetComponent<TimelineController4>().Play();
            GameObject.Find("/palm_water4/Cube/Cube_004").GetComponent<move_water4>().Move();
            GameObject.Find("tree-palm4").GetComponent<trigger4_palm>().Move();
            GameObject.Find("palm_water4").GetComponent<base_move4>().Move();
            animator.SetInteger("activation_number", -1);
        }
        if(temp == 5)
        {
            GameObject.Find("/palm_water5/palm_base/palm_base5").GetComponent<TimelineController5>().Play();
            GameObject.Find("/palm_water5/Cube/Cube_004").GetComponent<move_water5>().Move();
            GameObject.Find("tree-palm5").GetComponent<trigger5_palm>().Move();
            GameObject.Find("palm_water5").GetComponent<base_move5>().Move();
            animator.SetInteger("activation_number", -1);
        }
    }

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    {
        animator.SetBool("in_lake_range", false);
        animator.SetBool("has_water", false);
        animator.SetBool("in_range_of_plant", false);
        PlayerPrefs.SetInt("isMoist", 0);
    }
}
